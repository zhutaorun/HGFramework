using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 日志输出接口
/// </summary>
public interface ILogOutput
{
    /// <summary>
    /// 输出日志数据
    /// </summary>
    /// <param name="logData">日志数据</param>
    void Log(Logger.LogData logData);
}

/// <summary>
/// UI日志输出
/// </summary>
public class UILogOutput : ILogOutput
{
    /// <summary>
    /// 日志颜色
    /// </summary>
    private Color LogColor = Color.white;
    private Color WarningColor = Color.yellow;
    private Color AssertColor = Color.magenta;
    private Color ErrorColor = Color.red;


    /// <summary>
    /// 最大缓存日志数量
    /// </summary>
    private int MaxLogCount = 40;

    private List<Logger.LogData> logDataList = null;
    private Rect logRect; 

    public UILogOutput()
    {
        this.logDataList = new List<Logger.LogData>(30);
        Console.Instance().onGUICallback += OnGUI;
    }

    public void Log(Logger.LogData logData)
    {
        if (logData == null)
            return;
        if (logData.Level < Logger.Instance().uiOutputLogLevel)
            return;

        if (this.logDataList.Count > MaxLogCount)
            this.logDataList.RemoveAt(0);
        this.logDataList.Add(logData);
    }

    void OnGUI()
    {
        // 重新定位日志输出位置
        this.logRect = new Rect(5, 10, Screen.width - 20, 20);
        // 输出当前缓存的日志数据
        for (int i = 0; i < this.logDataList.Count; ++i)
        {
            Logger.LogData logData = this.logDataList[i];
            switch (logData.Level)
            {
                case Logger.LogLevel.LOG:
                    Print(LogColor, logData.Log);
                    break;
                case Logger.LogLevel.WARNING:
                    Print(WarningColor, logData.Log);
                    break;
                case Logger.LogLevel.ASSERT:
                    Print(AssertColor, logData.Log + logData.Track);
                    break;
                case Logger.LogLevel.ERROR:
                    Print(ErrorColor, logData.Log + logData.Track);
                    break;
                default:
                    break;
            }
        }
    }

    void Print(Color color, string log)
    {
        Color c = GUI.skin.label.normal.textColor;
        GUI.skin.label.normal.textColor = color;
        string[] lines = log.Split('\n');
        for (int i = 0; i < lines.Length; ++i)
        {
            string line = lines[i];
            if (string.IsNullOrEmpty(line))
                continue;
            GUI.Label(this.logRect, line);
            this.logRect.y += 20;
        }
        GUI.skin.label.normal.textColor = c;
    }
}

/// <summary>
/// 文本日志输出
/// </summary>
public class FileLogOutput : ILogOutput
{


    public void Log(Logger.LogData logData)
    {

    }
}