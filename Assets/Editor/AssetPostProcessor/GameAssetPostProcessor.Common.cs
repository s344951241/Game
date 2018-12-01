using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Game.Editor
{
    public partial class GameAssetPostProcessor
    {
        private static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
        {
            #region 处理 table
            bool foundTablet = false;
            foreach (string assetPath in importedAssets)
            {
                if (!assetPath.ToLower().EndsWith(".txt"))
                {
                    continue;
                }
                if (!assetPath.StartsWith("Assets/GameMain/DataTables"))
                {
                    continue;
                }
                foundTablet = true;
            }

            foreach (string assetPath in deletedAssets)
            {
                if (!assetPath.ToLower().EndsWith(".txt"))
                {
                    continue;
                }
                if (!assetPath.StartsWith("Assets/GameMain/DataTables"))
                {
                    continue;
                }
                foundTablet = true;
            }
            if (foundTablet)
            {
                AssetGenerator.GenerateTableList();
                AssetDatabase.SaveAssets();
            }
            #endregion

            #region 处理 Lua 脚本

            string LuaScriptPath = "Assets/GameMain/LuaScripts/";
            bool foundLuaScripts = false;
            foreach (string assetPath in importedAssets)
            {
                if (!assetPath.ToLower().EndsWith(".lua"))
                {
                    continue;
                }

                if (!assetPath.StartsWith(LuaScriptPath))
                {
                    continue;
                }

                foundLuaScripts = true;

                LabelUtility.SetLabel(assetPath, "LuaScript");

                if (Application.isPlaying && GameEntry.Base != null && GameEntry.Base.EditorResourceMode && GameEntry.Lua != null)
                {
                    GameEntry.Lua.ReloadScriptInEditor(assetPath.Substring(LuaScriptPath.Length, assetPath.Length - LuaScriptPath.Length - 4));
                }
            }

            if (foundLuaScripts)
            {
                AssetGenerator.GenerateLuaScriptList();
                AssetDatabase.SaveAssets();
            }

            #endregion 处理 Lua 脚本
        }
    }
}

