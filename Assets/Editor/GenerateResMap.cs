using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
using System.Text;

/// <summary>
/// 生成Lua及其路径映射，在android平台，不能遍历目录读取所有lua文件
/// 或者用打包的方式保存所有lua文件
/// </summary>
public class GenerateResMap : AssetPostprocessor
{
    static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPath)
    {
        if (ContainsPath(importedAssets) || ContainsPath(deletedAssets) || ContainsPath(movedAssets) || ContainsPath(movedFromAssetPath))
            Generate();
    }

    static bool ContainsPath(string[] assets)
    {
        if (assets == null)
            return false;

        for (int i = 0; i < assets.Length; ++i)
        {
            string asset = assets[i];
            if (asset.Contains("Assets/StreamingAssets/Config") || asset.Contains("Assets/StreamingAssets/LuaProject"))
                return true;
        }
        return false;
    }

    static void Generate()
    {
        GenerateMap(Application.streamingAssetsPath + "/LuaProject/", ".lua", "luas.txt");
        GenerateMap(Application.streamingAssetsPath + "/Config/", ".bytes", "configs.txt");
        Debug.Log("Generate Config and Lua Map OK!");
    }

    static void GenerateMap(string path, string filter, string ini)
    {
        DirectoryInfo luaDI = new DirectoryInfo(path);
        FileInfo[] luaFIs = luaDI.GetFiles("*.*", SearchOption.AllDirectories);
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < luaFIs.Length; ++i)
        {
            FileInfo luaFI = luaFIs[i];
            if (luaFI.Extension != filter)
                continue;
            string rPath = luaFI.FullName.Replace(Path.DirectorySeparatorChar, '/');
            rPath = rPath.Replace(path, string.Empty);
            builder.Append(rPath);
            builder.Append('\n');
        }
        File.WriteAllText(path + ini, builder.ToString().TrimEnd(), Encoding.ASCII);
        AssetDatabase.Refresh();
    }
}
