using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
using System.Collections.Generic;

public class Builder 
{
    const string BuildAssetBundlesMenu = "Tools/Build AssetBundles/";
    const string CopyAssetBundlesMenu = "Tools/Copy AssetBundles/";
    const string AssetBundlesPath = "/../AssetBundles/";
    const string PC = "PC";
    const string IOS = "IOS";
    const string Android = "Android";
    const string AssetBundles = "/AssetBundles";

    [MenuItem(BuildAssetBundlesMenu + PC)]
    static void BuildPCAssetBundles()
    {
        BuildAssetBundles(BuildTarget.StandaloneWindows);
    }

    [MenuItem(BuildAssetBundlesMenu + IOS)]
    static void BuildIOSAssetBundles()
    {
        BuildAssetBundles(BuildTarget.iOS);
    }

    [MenuItem(BuildAssetBundlesMenu + Android)]
    static void BuildAndroidAssetBundles()
    {
        BuildAssetBundles(BuildTarget.Android);
    }

    static void BuildAssetBundles(BuildTarget targetPlatform)
    {
        // 需要将脚本和配置数据拷贝到临时目录，因为unity不允许自定义后缀的文件打成assetbundle，比如.lua
        // 先设置脚本文件
        string srcPath = Application.streamingAssetsPath + "/LuaProject";
        string desPath = Application.dataPath + "/LuaProject";
        DirectoryCopy(srcPath, desPath, true);
        // 先对.lua后缀的文件进行改名操作，后缀加.txt
        AddSuffix(desPath, ".lua", ".txt");
        SetAssetBundleName(desPath, "script.lua", ".txt");
        // 再设置配置表资源
        srcPath = Application.streamingAssetsPath + "/Config";
        desPath = Application.dataPath + "/Config";
        DirectoryCopy(srcPath, desPath, true);
        AssetDatabase.Refresh();
        SetAssetBundleName(desPath, "config.bytes", ".bytes", ".txt");
        // 根据平台得到输出目录
        string path = GetPlatformPath(targetPlatform);
        // 执行Build操作
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        BuildPipeline.BuildAssetBundles(path, BuildAssetBundleOptions.DisableWriteTypeTree, targetPlatform);
        AssetDatabase.Refresh();
        Debug.Log("Build AssetBundles OK");
        // 将最新生成的AssetBundles拷贝到StreamingAssets目录
        DirectoryCopy(path, Application.streamingAssetsPath + "/AssetBundles", true);
        Debug.Log("Copy AssetBundles OK");
        // 删除临时目录
        Directory.Delete(Application.dataPath + "/LuaProject", true);
        Directory.Delete(Application.dataPath + "/Config", true);
        AssetDatabase.Refresh();
    }

    static void AddSuffix(string path, string filter, string suffix)
    {
        DirectoryInfo di = new DirectoryInfo(path);
        FileInfo[] fis = di.GetFiles("*.*", SearchOption.AllDirectories);
        foreach (FileInfo fi in fis)
        {
            if (fi.Extension == filter)
                File.Copy(fi.FullName, fi.FullName + suffix, true);
        }
        AssetDatabase.Refresh();
    }

    static void SetAssetBundleName(string path, string name, params string[] exts)
    {
        DirectoryInfo di = new DirectoryInfo(path);
        FileInfo[] fis = di.GetFiles("*.*", SearchOption.AllDirectories);
        foreach (FileInfo fi in fis)
        {
            if (!Filter(fi.Name, exts))
                continue;
            string assetPath = fi.FullName.Replace(Path.DirectorySeparatorChar, '/');
            assetPath = "Assets" + assetPath.Substring(Application.dataPath.Length);
            AssetImporter ai = AssetImporter.GetAtPath(assetPath);
            ai.assetBundleName = name;
        }
        AssetDatabase.Refresh();
        Debug.Log("Set " + path + " OK!");
    }

    static bool Filter(string str, params string[] exts)
    {
        if (exts == null)
            return false;
        foreach (string ext in exts)
        {
            if (str.EndsWith(ext))
                return true;
        }
        return false;
    }

    static string GetPlatformPath(BuildTarget target)
    {
        switch (target)
        {
            case BuildTarget.StandaloneWindows:
            case BuildTarget.StandaloneWindows64:
            case BuildTarget.StandaloneOSXIntel:
            case BuildTarget.StandaloneOSXIntel64:
                return Application.dataPath + AssetBundlesPath + PC + AssetBundles;
            case BuildTarget.iOS:
                return Application.dataPath + AssetBundlesPath + IOS + AssetBundles;
            case BuildTarget.Android:
                return Application.dataPath + AssetBundlesPath + Android + AssetBundles;
            default:
                return null;
        }
    }

    private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
    {
        // Get the subdirectories for the specified directory.
        DirectoryInfo dir = new DirectoryInfo(sourceDirName);
        DirectoryInfo[] dirs = dir.GetDirectories();

        if (!dir.Exists)
        {
            throw new DirectoryNotFoundException(
                "Source directory does not exist or could not be found: "
                + sourceDirName);
        }

        // If the destination directory doesn't exist, create it. 
        if (!Directory.Exists(destDirName))
        {
            Directory.CreateDirectory(destDirName);
        }

        // Get the files in the directory and copy them to the new location.
        FileInfo[] files = dir.GetFiles();
        foreach (FileInfo file in files)
        {
            string temppath = Path.Combine(destDirName, file.Name);
            file.CopyTo(temppath, true);
        }

        // If copying subdirectories, copy them and their contents to new location. 
        if (copySubDirs)
        {
            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(destDirName, subdir.Name);
                DirectoryCopy(subdir.FullName, temppath, copySubDirs);
            }
        }
    }

    [MenuItem("Tools/Get Dependences")]
    static void GetDependences()
    {
        Caching.CleanCache();
        string selectionPath = AssetDatabase.GetAssetPath(Selection.activeObject);
        string[] dependences = AssetDatabase.GetDependencies(new string[] { selectionPath });
        foreach (string dependence in dependences)
            Debug.Log(dependence);
    }
}
