using UnityEngine;
using System.Collections;
using SLua;

/// <summary>
/// 全局唯一继承于MonoBehaviour的单例类，保证其他公共模块都以Game的生命周期为准
/// </summary>
public class Game : MonoSingleton<Game>
{
    public delegate void LifeCircleCallback();

    public LifeCircleCallback onUpdate = null;
    public LifeCircleCallback onGUI = null;
    public LifeCircleCallback onDestroy = null;
    public LifeCircleCallback onApplicationQuit = null;

    public string startScript = null;
    public bool showLogOnGUI = false;
#if UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX
    public Vector2 windowSize = new Vector2(1024, 768);
#endif

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        instance = this;
        // 进入欢迎界面
    }

    IEnumerator Start()
    {
#if UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX
        Screen.SetResolution((int)this.windowSize.x, (int)this.windowSize.y, false);
#endif
        // 初始化公共模块
        Console.Instance();
        Logger.Instance();
        // 需要先加载AssetBundleManifest
        yield return StartCoroutine(ResMgr.Instance().Init());
        // 加载配置数据
        yield return StartCoroutine(ConfigMgr.Instance().Init());
        // 启动脚本，开始逻辑
        yield return StartCoroutine(LuaMgr.Instance().Init());
    }

    void Update()
    {
        if (this.onUpdate != null)
            this.onUpdate();
    }

    void OnGUI()
    {
        if (this.onGUI != null)
            this.onGUI();
    }

    void OnDestroy()
    {
        if (this.onDestroy != null)
            this.onDestroy();
    }

    void OnApplicationQuit()
    {
        if (this.onApplicationQuit != null)
            this.onApplicationQuit();
    }
}
