using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using UnityEngine;
using SLua;

[CustomLuaClass]
public static class Setting
{
    private static Dictionary<string, string> settings = null;

    public static void Load()
    {
        settings = new Dictionary<string, string>();
        // 加载配置
        string settingPath = Application.persistentDataPath + "/setting.txt";
        if (!File.Exists(settingPath))
            return;
        // 解析配置
        // 配置格式：key=value
        string[] lines = File.ReadAllLines(settingPath);
        for (int i = 0; i < lines.Length; ++i)
        {
            string line = lines[i];
            string[] kv = line.Split('=');
            Logger.Assert(kv.Length == 2, "Error Setting Format : " + line);
            string k = kv[0].Trim();
            string v = kv[1].Trim();
            settings[k] = v;
        }
    }

    public static void Save()
    {
        // 保存配置
        string settingPath = Application.persistentDataPath + "/setting.txt";
        List<string> lines = new List<string>();
        foreach (KeyValuePair<string, string> kv in settings)
            lines.Add(string.Format("{0}={1}", kv.Key, kv.Value));
        File.WriteAllLines(settingPath, lines.ToArray());
    }

    public static int GetInt(string key, int defaultVal = 0)
    {
        string val = null;
        if (settings.TryGetValue(key, out val))
            return System.Convert.ToInt32(val);
        settings[key] = defaultVal.ToString();
        return defaultVal;
    }

    public static float GetFloat(string key, float defaultVal = 0f)
    {
        string val = null;
        if (settings.TryGetValue(key, out val))
            return System.Convert.ToSingle(val);
        settings[key] = defaultVal.ToString();
        return defaultVal;
    }

    public static bool GetBool(string key, bool defaultVal = false)
    {
        string val = null;
        if (settings.TryGetValue(key, out val))
            return System.Convert.ToBoolean(val);
        settings[key] = defaultVal.ToString();
        return defaultVal;
    }

    public static string GetString(string key, string defaultVal = "")
    {
        string val = null;
        if (settings.TryGetValue(key, out val))
            return val.ToString();
        settings[key] = defaultVal.ToString();
        return defaultVal;
    }

    public static void SetInt(string key, int val)
    {
        settings[key] = val.ToString();
    }

    public static void SetFloat(string key, float val)
    {
        settings[key] = val.ToString();
    }

    public static void SetBool(string key, bool val)
    {
        settings[key] = val.ToString();
    }

    public static void SetString(string key, string val)
    {
        settings[key] = val;
    }
}
