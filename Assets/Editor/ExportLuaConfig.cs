using UnityEngine;
using UnityEditor;
using System.Collections;
using System;
using System.Reflection;
using System.IO;

public class ExportLuaConfig 
{
    static string paramDesc = "--<param name = \"{0}\", type = \"{1}\">";
    static string returnDesc = "--<return type = \"{0}\">";

    [MenuItem("Tools/Export LuaConfig")]
    static void Export()
    {
        if (EditorApplication.isCompiling)
            return;

        StreamWriter sw = new StreamWriter("D://a.lua");
        Assembly assembly = Assembly.Load("UnityEngine");
        Type[] types = assembly.GetExportedTypes();
        foreach (Type type in types)
        {
            if (type.IsEnum)
            {
                ExportEnum(sw, type);
            }
            else
            {
                ExportStaticMethod(sw, type);
                ExportMemberMethod(sw, type);
            }
        }
        sw.Close();
    }

    /// <summary>
    /// 输出枚举
    /// </summary>
    /// <param name="sw"></param>
    /// <param name="type"></param>
    static void ExportEnum(StreamWriter sw, Type type)
    {
        foreach (object enumVal in Enum.GetValues(type))
        {
            string enu = "{0}.{1}";
            sw.WriteLine(string.Format(enu, type.Name, enumVal.ToString()));
        }
        sw.WriteLine();
    }

    /// <summary>
    /// 输出静态方法
    /// </summary>
    /// <param name="sw"></param>
    /// <param name="type"></param>
    static void ExportStaticMethod(StreamWriter sw, Type type)
    {
        BindingFlags flag = BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly;
        MethodInfo[] mis = type.GetMethods(flag);
        foreach (MethodInfo mi in mis)
        {
            string func = "function {0}.{1}({2})\nend\n";
            ParameterInfo[] pis = mi.GetParameters();
            string args = "";
            foreach (ParameterInfo pi in pis)
            {
                // 注释
                sw.WriteLine(string.Format(paramDesc, pi.Name, pi.ParameterType));
                // 提示
                if (string.IsNullOrEmpty(args))
                {
                    args += pi.Name;
                }
                else
                {
                    args += ", " + pi.Name;
                }
            }
            sw.WriteLine(string.Format(returnDesc, mi.ReturnType));
            sw.WriteLine(string.Format(func, type.Name, mi.Name, args));
        }
    }

    /// <summary>
    /// 输出成员方法
    /// </summary>
    /// <param name="sw"></param>
    /// <param name="type"></param>
    static void ExportMemberMethod(StreamWriter sw, Type type)
    {
        BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly;
        MethodInfo[] mis = type.GetMethods(flag);
        foreach (MethodInfo mi in mis)
        {
            string func = "function {0}:{1}({2})\nend\n";
            ParameterInfo[] pis = mi.GetParameters();
            string args = "";
            foreach (ParameterInfo pi in pis)
            {
                // 注释
                sw.WriteLine(string.Format(paramDesc, pi.Name, pi.ParameterType));
                // 提示
                if (string.IsNullOrEmpty(args))
                {
                    args += pi.Name;
                }
                else
                {
                    args += ", " + pi.Name;
                }
            }
            sw.WriteLine(string.Format(returnDesc, mi.ReturnType));
            // *代表通配符
            sw.WriteLine(string.Format(func, "*", mi.Name, args));
        }
    }
}
