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

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        instance = this;
        // 进入欢迎界面

    }

    IEnumerator Start()
    {
        Debug.LogWarning("Game Start : " + System.DateTime.Now);
        // 加载配置
        Setting.Load();
        // 构造公共模块
        Console.Instance();
        Logger.Instance();
        ResMgr.Instance();
        ConfigMgr.Instance();
        LuaMgr.Instance();
        Debug.LogWarning("Res Start : " + System.DateTime.Now);
        // 初始化公共模块
        // 初始化资源管理器
        yield return StartCoroutine(ResMgr.Instance().Init());
        Debug.LogWarning("Config Start : " + System.DateTime.Now);
        // 初始化配置数据管理器
        yield return StartCoroutine(ConfigMgr.Instance().Init());
        Debug.LogWarning("Lua Start : " + System.DateTime.Now);
        // 初始化脚本管理器，启动脚本，开始逻辑
        yield return StartCoroutine(LuaMgr.Instance().Init());
        Debug.LogWarning("Game Start Done : " + System.DateTime.Now);

#if UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX
        Screen.SetResolution(Setting.GetInt("WindowWidth", 1024), 
            Setting.GetInt("WindowHeight", 768), false);
#endif
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
        // 保存配置
        Setting.Save();
    }
}
