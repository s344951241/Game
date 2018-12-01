using GameFramework;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Game.Editor
{
    public class AssetGenerator : EditorWindow
    {

        private static readonly string _tablePath = Utility.Path.GetCombinePath(Application.dataPath, "GameMain/DataTables");
        private static readonly string _tableListFileName = Utility.Path.GetCombinePath(Application.dataPath, "GameMain/DataTables/TableList.txt");
        private static readonly List<string> _tableNames = new List<string>();


        [MenuItem("Game Tools/资源工具/生成列表/生成table列表")]
        public static void GenerateTableList()
        {
            DirectoryInfo tableDirectory = new DirectoryInfo(_tablePath);
            if (!tableDirectory.Exists)
            {
                Debug.LogWarning(Utility.Text.Format("Table directory '{0}' is not exist.", tableDirectory));
                return;
            }

            _tableNames.Clear();
            FileInfo[] tableFiles = tableDirectory.GetFiles("*.txt", SearchOption.AllDirectories);
            foreach (FileInfo tableFile in tableFiles)
            {
               
                string tableFileName = tableFile.FullName.Replace('\\', '/');
                if (tableFileName.Contains(_tableListFileName))
                    continue;
                if (!tableFileName.StartsWith(_tablePath) || !tableFileName.ToLower().EndsWith(".txt"))
                {
                    Debug.LogWarning(Utility.Text.Format("table file name '{0}' is invalid.", tableFileName));
                    continue;
                }

                _tableNames.Add(tableFileName.Substring(_tablePath.Length + 1, tableFileName.Length - _tablePath.Length - 5));
            }

            File.WriteAllText(_tableListFileName, string.Join("\r\n", _tableNames.ToArray()), Encoding.UTF8);
            AssetDatabase.Refresh();
            Debug.Log("Generate table list complete.");
        }

        private static readonly string _luaScriptPath = Utility.Path.GetCombinePath(Application.dataPath, "GameMain/LuaScripts");
        private static readonly string _luaScriptListFileName = Utility.Path.GetCombinePath(Application.dataPath, "GameMain/LuaScripts/LuaScriptList.txt");
        private static readonly List<string> _luaScriptNames = new List<string>();

        [MenuItem("Game Tools/资源工具/生成列表/生成Lua脚本列表")]
        public static void GenerateLuaScriptList()
        {
            DirectoryInfo luaScriptDirectory = new DirectoryInfo(_luaScriptPath);
            if (!luaScriptDirectory.Exists)
            {
                Debug.LogWarning(Utility.Text.Format("Lua script directory '{0}' is not exist.", _luaScriptPath));
                return;
            }

            _luaScriptNames.Clear();
            FileInfo[] luaScriptFiles = luaScriptDirectory.GetFiles("*.lua", SearchOption.AllDirectories);
            foreach (FileInfo luaScriptFile in luaScriptFiles)
            {
                string luaScriptFileName = luaScriptFile.FullName.Replace('\\', '/');
                if (!luaScriptFileName.StartsWith(_luaScriptPath) || !luaScriptFileName.ToLower().EndsWith(".lua"))
                {
                    Debug.LogWarning(Utility.Text.Format("Lua script file name '{0}' is invalid.", luaScriptFileName));
                    continue;
                }

                _luaScriptNames.Add(luaScriptFileName.Substring(_luaScriptPath.Length + 1, luaScriptFileName.Length - _luaScriptPath.Length - 5));
            }

            File.WriteAllText(_luaScriptListFileName, string.Join("\r\n", _luaScriptNames.ToArray()), Encoding.UTF8);
            AssetDatabase.Refresh();
            Debug.Log("Generate lua script list complete.");
        }
    }

}
