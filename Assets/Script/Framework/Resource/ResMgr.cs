using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SLua;
using System.IO;

// 资源管理器，封装开发模式和发布模式
[CustomLuaClass]
public class ResMgr : Singleton<ResMgr>
{
    // AssetBundle中资源路径格式
    public static string AssetBundleFormation = "assets/resources/{0}";
    // 版本号文件
    public static string VersionFile = "version.txt";
    // 应用资源目录URL，带不同平台的协议头
    public static string AppURL = null;
    // 设备更新目录
    public static string DeviceUpdatePath = null;
    // 设备更新目录URL，带file://协议头
    public static string DeviceURL = null;
    // 线上资源目录URL，带http://协议头
    public static string OnlineURL = null;
    // 版本文件
    public static string AppVersionURL = null;
    public static string DeviceVersionURL = null;
    public static string OnlineVersionURL = null;

    // 正在加载的资源映射
    private Dictionary<string, IResLoader> loadingResDict = null;
    // 正在加载的资源映射中加载完成的资源列表，准备删除，避免遍历删除的语法规则
    private List<string> loadedResList = null;
    // 正在加载的场景
    private SceneLoader sceneLoader = null;
    private SceneLoader deleteSceneLoader = null;

    // 已经加载完成的AssetBundle
    private Dictionary<string, AssetBundleLoader> loadedAssetBundleLoaderDict = null;
    private Dictionary<string, AssetBundleSceneLoader> loadedAssetBundleSceneLoaderDict = null;
    // AssetBundleManifest
    private AssetBundleManifest manifest = null;

    private ResMgr()
    {
        // TODO 根据渠道不同，所在目录会有不同
#if UNITY_ANDROID
        AppURL = Application.streamingAssetsPath + "/AssetBundles/";
        DeviceUpdatePath = Application.persistentDataPath;
        OnlineURL = "http://192.168.0.22:8080/assets/android/";
#elif UNITY_IOS
        AppURL = "file://" + Application.streamingAssetsPath + "/AssetBundles/";
        DeviceUpdatePath = Application.persistentDataPath;
        OnlineURL = "http://192.168.0.22:8080/assets/ios/";
#elif UNITY_STANDALONE_WIN
        AppURL = "file://" + Application.streamingAssetsPath + "/AssetBundles/";
        DeviceUpdatePath = Application.persistentDataPath;
        OnlineURL = "http://192.168.0.22:8080/assets/pc/";
#elif UNITY_STANDALONE_OSX
        AppURL = "file://" + Application.streamingAssetsPath + "/AssetBundles/";
        DeviceUpdatePath = Application.persistentDataPath;
#endif
        DeviceURL = "file://" + DeviceUpdatePath;
        AppVersionURL = AppURL + VersionFile;
        DeviceVersionURL = DeviceURL + VersionFile;
        OnlineVersionURL = OnlineURL + VersionFile;

        this.loadedAssetBundleLoaderDict = new Dictionary<string, AssetBundleLoader>();
        this.loadedAssetBundleSceneLoaderDict = new Dictionary<string, AssetBundleSceneLoader>();
        this.loadingResDict = new Dictionary<string, IResLoader>();
        this.loadedResList = new List<string>(20);
        Game.Instance().onUpdate += Update;
        Game.Instance().onDestroy += OnDestroy;
    }

    /// <summary>
    /// 保证在ASSETBUNDLE方式下，首先加载资源清单
    /// </summary>
    /// <returns></returns>
    public IEnumerator Init()
    {
#if ASSETBUNDLE
        yield return Game.Instance().StartCoroutine(CompareByApp());
#else
        yield return null;
#endif
    }

    /// <summary>
    /// 与客户端版本号进行比对
    /// </summary>
    /// <returns></returns>
    IEnumerator CompareByApp()
    {
        // 应用内没有version.txt，即首次安装的游戏，使用客户端资源更新目录
        if (!File.Exists(DeviceUpdatePath + VersionFile))
        {
            yield return Game.Instance().StartCoroutine(UpdateByApp());
        }
        else
        {
            // 比对客户端和应用内version.txt
            WWW www = new WWW(AppVersionURL);
            yield return www;
            Debug.LogWarning("App Version : " + www.text);
            Version appVer = Version.CreateVersion(www.text);
            www = new WWW(DeviceVersionURL);
            yield return www;
            Debug.LogWarning("Device Version : " + www.text);
            Version deviceVer = Version.CreateVersion(www.text);

            // 如果应用版本号大于设备版本号，则先用应用资源更新设备
            if (appVer.BigVersion > deviceVer.BigVersion || 
                appVer.MiddleVersion > deviceVer.MiddleVersion ||
                appVer.SmallVersion > deviceVer.SmallVersion ||
                appVer.ResVersion > deviceVer.ResVersion)
            {
                // 使用客户端资源更新目录
                yield return Game.Instance().StartCoroutine(UpdateByApp());
            }
            else
            {
                // 跳过客户端更新，直接进行线上版本比对
                yield return Game.Instance().StartCoroutine(CompareByOnline());
            }
        }
    }

    /// <summary>
    /// 以客户端版本号为参考，更新应用
    /// </summary>
    /// <returns></returns>
    IEnumerator UpdateByApp()
    {
        Debug.LogWarning("---------------------Update By App---------------------");
        // PC平台此目录可能不存在
        if (!Directory.Exists(DeviceUpdatePath))
            Directory.CreateDirectory(DeviceUpdatePath);

        // 首次启动应用时
        WWW www = new WWW(AppURL + "AssetBundles");
        yield return www;
        // 遍历所有应用内assetbundle，拷贝至设备更新目录
        AssetBundleManifest manifest = www.assetBundle.LoadAsset("AssetBundleManifest") as AssetBundleManifest;
        string[] allAssetBundles = manifest.GetAllAssetBundles();
        // AssetBundle不能同名多次加载
        www.assetBundle.Unload(false);
        for (int i = 0; i < allAssetBundles.Length; ++i)
        {
            string assetbundle = allAssetBundles[i];
            www = new WWW(string.Format(AppURL + assetbundle));
            yield return www;
            File.WriteAllBytes(DeviceUpdatePath + assetbundle, www.bytes);
            www = new WWW(string.Format("{0}{1}.manifest", AppURL, assetbundle));
            yield return www;
            File.WriteAllBytes(string.Format("{0}{1}.manifest", DeviceUpdatePath, assetbundle), www.bytes);
        }

        // 拷贝AssetBundle
        www = new WWW(AppURL + "AssetBundles");
        yield return www;
        File.WriteAllBytes(DeviceUpdatePath + "AssetBundles", www.bytes);

        // 拷贝AssetBundleManifest
        www = new WWW(AppURL + "AssetBundles.manifest");
        yield return www;
        File.WriteAllBytes(DeviceUpdatePath + "AssetBundles.manifest", www.bytes);

        // 拷贝Version.txt
        www = new WWW(AppURL + VersionFile);
        yield return www;
        File.WriteAllBytes(DeviceUpdatePath + VersionFile, www.bytes);

        www.Dispose();
        www = null;
        yield return Resources.UnloadUnusedAssets();
        
        // 和线上版本比对，此时还有可能玩家下载了游戏很久，却没有打开过，此间经历了一些版本
        yield return Game.Instance().StartCoroutine(CompareByOnline());
    }

    IEnumerator CompareByOnline()
    {
        WWW www = new WWW(DeviceVersionURL);
        yield return www;
        Debug.LogWarning("Compare By Online Device Version : " + www.text);
        Version deviceVer = Version.CreateVersion(www.text);
        www = new WWW(OnlineVersionURL);
        yield return www;
        Debug.LogWarning("Compare By Online Online Version : " + www.text);
        Version onlineVer = Version.CreateVersion(www.text);

        if (onlineVer.BigVersion > deviceVer.BigVersion ||
            onlineVer.MiddleVersion > deviceVer.MiddleVersion)
        {
            // TODO 强制玩家更新客户端

        }
        else if (onlineVer.SmallVersion > deviceVer.SmallVersion ||
            onlineVer.ResVersion > deviceVer.ResVersion)
        {
            // 需要更新资源
            yield return Game.Instance().StartCoroutine(UpdateByOnline());
        }
        else
        {
            // 可以直接进入游戏
            yield return Game.Instance().StartCoroutine(LoadAssetbundleManifest());
        }
    }

    /// <summary>
    /// 以线上版本号为参考，更新应用
    /// </summary>
    /// <returns></returns>
    IEnumerator UpdateByOnline()
    {
        Debug.LogWarning("-----------------Update By Online------------------");
        // 计算下载列表
        // 下载AssetBundleManifest
        WWW www = new WWW(OnlineURL + "AssetBundles");
        yield return www;
        AssetBundleManifest onlineManifest = www.assetBundle.LoadAsset("AssetBundleManifest") as AssetBundleManifest;
        www.assetBundle.Unload(false);
        www = new WWW(DeviceURL + "AssetBundles");
        yield return www;
        AssetBundleManifest deviceManifest = www.assetBundle.LoadAsset("AssetBundleManifest") as AssetBundleManifest;
        www.assetBundle.Unload(false);
        // 下载列表
        List<string> downloadAssetBundleList = new List<string>();
        string[] allOnlineAssetBundles = onlineManifest.GetAllAssetBundles();
        for (int i = 0; i < allOnlineAssetBundles.Length; ++i)
        {
            string onlineAssetBundle = allOnlineAssetBundles[i];
            if (!File.Exists(DeviceUpdatePath + onlineAssetBundle))
            {
                downloadAssetBundleList.Add(onlineAssetBundle);
            }
            else
            {
                Hash128 onlineAssetBundleHash = onlineManifest.GetAssetBundleHash(onlineAssetBundle);
                Hash128 deviceAssetBundleHash = deviceManifest.GetAssetBundleHash(onlineAssetBundle);
                if (!onlineAssetBundleHash.Equals(deviceAssetBundleHash))
                    downloadAssetBundleList.Add(onlineAssetBundle);
            }
        }
        for (int i = 0; i < downloadAssetBundleList.Count; ++i)
        {
            string assetbundle = downloadAssetBundleList[i];
            Debug.LogWarning("-------------------Download : " + assetbundle);
            www = new WWW(string.Format(OnlineURL + assetbundle));
            yield return www;
            string assetbundlePath = DeviceUpdatePath + assetbundle;
            File.Delete(assetbundlePath);
            File.WriteAllBytes(assetbundlePath, www.bytes);
            www = new WWW(string.Format("{0}{1}.manifest", OnlineURL, assetbundle));
            yield return www;
            string manifestPath = string.Format("{0}{1}.manifest", DeviceUpdatePath, assetbundle);
            File.Delete(manifestPath);
            File.WriteAllBytes(manifestPath, www.bytes);
        }

        // 下载AssetBundle
        www = new WWW(OnlineURL + "AssetBundles");
        yield return www;
        File.WriteAllBytes(DeviceUpdatePath + "AssetBundles", www.bytes);

        // 下载AssetBundleManifest
        www = new WWW(OnlineURL + "AssetBundles.manifest");
        yield return www;
        File.WriteAllBytes(DeviceUpdatePath + "AssetBundles.manifest", www.bytes);

        // 下载Version.txt
        www = new WWW(OnlineURL + VersionFile);
        yield return www;
        File.WriteAllBytes(DeviceUpdatePath + VersionFile, www.bytes);

        www.Dispose();
        www = null;
        yield return Resources.UnloadUnusedAssets();
        
        yield return Game.Instance().StartCoroutine(LoadAssetbundleManifest());
    }

    /// <summary>
    /// 加载最新的AssetBundleManifest，准备进入游戏
    /// </summary>
    /// <returns></returns>
    IEnumerator LoadAssetbundleManifest()
    {
        WWW www = new WWW(DeviceURL + "AssetBundles");
        yield return www;
        this.manifest = www.assetBundle.LoadAsset("AssetBundleManifest") as AssetBundleManifest;
    }

    void Update()
    {
        // 检查场景是否加载完成
        if (this.sceneLoader != null)
        {
            if (this.sceneLoader.IsDone())
            {
                SceneLoader loader = this.sceneLoader;
#if ASSETBUNDLE
                this.loadedAssetBundleSceneLoaderDict[loader.SceneName] = this.sceneLoader as AssetBundleSceneLoader;
#endif
                this.sceneLoader = null;
                if (loader.LoadDoneCallback != null)
                    loader.LoadDoneCallback(loader.SceneName);
            }
            else
            {
                if (this.sceneLoader.LoadUpdateCallback != null)
                    this.sceneLoader.LoadUpdateCallback(this.sceneLoader.SceneName, this.sceneLoader.GetProgress());
            }
        }
        // 遍历正在加载的资源，检测是否已经加载完成
        foreach (KeyValuePair<string, IResLoader> resLoaderKV in this.loadingResDict)
        {
            string resName = resLoaderKV.Key;
            IResLoader loader = resLoaderKV.Value;
            if (loader.IsDone())
            {
                //Debug.Log(string.Format("{0} done at {1}", resName, Time.frameCount));
                this.loadedResList.Add(resName);
            }
        }
        // 规避遍历字典删除元素的语法，在加载完成后可能会再次启动加载
        for (int i = 0; i < this.loadedResList.Count; ++i)
        {
            string resName = this.loadedResList[i];
            IResLoader loader = this.loadingResDict[resName];
#if ASSETBUNDLE
            // 加入到缓存的AssetBundle列表
            AssetBundleLoader abLoader = loader as AssetBundleLoader;
            this.loadedAssetBundleLoaderDict[resName] = abLoader;
#endif
            if (loader.LoadDoneCallback != null)
                loader.LoadDoneCallback(resName, loader.GetResObj());
            this.loadingResDict.Remove(resName);
        }
        this.loadedResList.Clear();
    }

    void OnDestroy()
    {
        // 卸载所有资源，避免编辑器异常
        this.loadingResDict.Clear();
        this.loadingResDict = null;
        this.loadedResList.Clear();
        this.loadedResList = null;
        if (this.loadedAssetBundleLoaderDict != null)
            this.loadedAssetBundleLoaderDict.Clear();
        this.loadedAssetBundleLoaderDict = null;
        Resources.UnloadUnusedAssets();
    }

    /// <summary>
    /// 获取资源依赖
    /// </summary>
    /// <param name="res">资源名</param>
    /// <returns>依赖资源名</returns>
    public string[] GetDependences(string res)
    {
        Logger.Assert(!string.IsNullOrEmpty(res), "GetDependeces res is NULL");
        return this.manifest.GetAllDependencies(res.ToLower());
    }

    /// <summary>
    /// 判断是否是已经加载完成的资源
    /// </summary>
    /// <param name="res">资源名</param>
    /// <returns></returns>
    public bool IsLoadedAssetBundle(string res)
    {
        return this.loadedAssetBundleLoaderDict.ContainsKey(res);
    }

    /// <summary>
    /// 加载资源
    /// </summary>
    /// <param name="resName"></param>
    /// <param name="loadDone"></param>
    /// <param name="updateProgress"></param>
    public void LoadRes(string resName, ResourceLoader.LoadResDoneCallback loadDone = null)
    {
        IResLoader loader = null;
#if ASSETBUNDLE
        AssetBundleLoader abLoader = null;
        // 如果已经加载过这个AssetBundle
        if (this.loadedAssetBundleLoaderDict.TryGetValue(resName, out abLoader))
        {
            // 检查依赖及assetbundle解压
            abLoader.CheckDependences();
            this.loadedAssetBundleLoaderDict.Remove(resName);
            this.loadingResDict[resName] = abLoader;
            return;
        }
#endif
        // 如果正在加载中，则将加载回调添加到已有的加载器
        if (this.loadingResDict.TryGetValue(resName, out loader))
        {
            //Debug.LogWarning(resName + " loading");
            if (loadDone != null)
                loader.LoadDoneCallback += loadDone;
            return;
        }
        // 新建加载器开始加载
#if ASSETBUNDLE
        loader = new AssetBundleLoader(resName, loadDone);
#else
        loader = new ResourceLoader(resName, loadDone);
#endif
        // 添加至正在加载列表
        AddLoadingLoader(loader);
        // 启动加载
        Game.Instance().StartCoroutine(loader);
    }

    /// <summary>
    /// 加载场景
    /// </summary>
    /// <param name="sceneName">场景名</param>
    /// <param name="additive">是叠加加载，还是独立加载</param>
    /// <param name="loadDone">加载完成回调</param>
    /// <param name="updateProgress">加载进度更新回调</param>
    public void LoadScene(string sceneName, bool additive, 
        SceneLoader.LoadSceneDoneCallback loadDone, SceneLoader.LoadSceneUpdateCallback updateProgress)
    {
        SceneLoader loader = null;
#if ASSETBUNDLE
        // TODO 检查已经加载的情况

        loader = new AssetBundleSceneLoader(sceneName, additive, loadDone, updateProgress);
#else
        loader = new SceneLoader(sceneName, additive, loadDone, updateProgress);
#endif
        // 启动加载
        Game.Instance().StartCoroutine(loader);
        this.sceneLoader = loader;
    }

    /// <summary>
    /// 施法资源内部实现，只卸载不用资源
    /// </summary>
    public void Unload()
    {
        // 确保当前没有正在加载中的资源
        if (this.loadingResDict.Count != 0)
        {
            Debug.LogWarning("There is loading resource... cannot unload");
            return;
        }
#if ASSETBUNDLE
        // 释放AssetBundle
        foreach (KeyValuePair<string, AssetBundleSceneLoader> sceneLoaderKV in this.loadedAssetBundleSceneLoaderDict)
            sceneLoaderKV.Value.Unload();
        foreach (KeyValuePair<string, AssetBundleLoader> loaderKV in this.loadedAssetBundleLoaderDict)
            loaderKV.Value.Unload();
        this.loadedAssetBundleSceneLoaderDict.Clear();
        this.loadedAssetBundleLoaderDict.Clear();
#endif
        Game.Instance().StartCoroutine(InternalUnloadAsync());
    }

    /// <summary>
    /// 异步释放资源内部实现
    /// </summary>
    /// <returns></returns>
    IEnumerator InternalUnloadAsync()
    {
        Debug.LogWarning("Unload in ResMgr");
        AsyncOperation opt = Resources.UnloadUnusedAssets();
        yield return opt;
    }

    /// <summary>
    /// 添加到"正在"加载资源列表
    /// </summary>
    /// <param name="loader">加载器</param>
    void AddLoadingLoader(IResLoader loader)
    {
        Logger.Assert((loader != null), "AddLoadingLoader loader is NULL");
        Logger.Assert(!this.loadingResDict.ContainsKey(loader.ResName), string.Format("Already Loading {0}", loader.ResName));
        //Debug.Log(string.Format("{0} start loading at {1}", loader.ResName, Time.frameCount));
        this.loadingResDict[loader.ResName] = loader;
    }
}
