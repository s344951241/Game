using GameFramework.Resource;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace Game
{
    public class TableComponent : GameFrameworkComponent
    {
        private const string _tableListFileName = "Assets/GameMain/DataTables/TableList.txt";
        private Dictionary<string, bool> _loadedFlags = new Dictionary<string, bool>();
        private static Dictionary<string, string> _tableData = new Dictionary<string, string>();

        private LoadAssetCallbacks _loadTableListCallbacks = null;
        private LoadAssetCallbacks _loadTableCallbacks = null;

        public bool IsAllTablesLoaded
        {
            get {
                if (_loadedFlags.Count <= 0)
                {
                    return false;
                }
                IEnumerator<bool> iter = _loadedFlags.Values.GetEnumerator();
                while (iter.MoveNext())
                {
                    if (!iter.Current)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private void Start()
        {
            _loadTableCallbacks = new LoadAssetCallbacks(LoadTableSuccessCallBack, LoadTableFailureCallBack);
            _loadTableListCallbacks = new LoadAssetCallbacks(LoadTableListSuccessCallBack, LoadTableListFailureCallBack);
        }
        public void LoadTables()
        {
            GameEntry.Resource.LoadAsset(_tableListFileName, Constant.AssetPriority.DataTableAsset, _loadTableListCallbacks);
        }
        private void LoadTable(string name,object userData=null)
        {
            if (string.IsNullOrEmpty(name))
            {
                Log.Warning("table name is invalid.");
                return;
            }
            string tableAssetName = AssetUtility.GetDataTableAsset(name);
            _loadedFlags.Add(name, false);
            GameEntry.Resource.LoadAsset(tableAssetName, Constant.AssetPriority.DataTableAsset, _loadTableCallbacks, userData);
        }

        private void LoadTableListSuccessCallBack(string tableListAssetName, object asset, float duration, object userData)
        {
            TextAsset tableList = asset as TextAsset;
            if (tableList == null)
            {
                Log.Error("table component load table list asset failure, which is not a TextAsset.");
                return;
            }
            string[] LineSplit = new string[] { "\r\n", "\r", "\n" };
            string[] tableNames = tableList.text.Split(LineSplit, StringSplitOptions.None);
            for (int i = 0; i < tableNames.Length; i++)
            {
                LoadTable(tableNames[i]);
            }
        }
        private void LoadTableListFailureCallBack(string tableAssetName, LoadResourceStatus status, string errorMessage, object userData)
        {
            Log.Error("Shader component load shader list asset failure, status is '{0}', error message is '{1}'.", status.ToString(), errorMessage);
        }

        private void LoadTableSuccessCallBack(string tableAssetName, object asset, float duration, object userData)
        {
            TextAsset tableAsset = asset as TextAsset;
            if (tableAsset == null)
            {
                Log.Warning("Table asset '{0}' is invalid.", tableAssetName);
                return;
            }
            if (!_tableData.ContainsKey(tableAsset.name))
            {
                _tableData.Add(tableAsset.name, tableAsset.text);
            }
            _loadedFlags[tableAsset.name] = true;
            Log.Info("Load table '{0}' OK, table name is '{1}', use '{2:F2}' seconds.", tableAssetName, tableAsset.name, duration);
        }

        private void LoadTableFailureCallBack(string tableAssetName, LoadResourceStatus status, string errorMessage, object userData)
        {
            Log.Error("Load table failure, asset name '{0}', status '{1}', error message '{2}'.", tableAssetName, status.ToString(), errorMessage);
        }

        public static string GetTable(string name)
        {
            if (_tableData.ContainsKey(name))
            {
                return _tableData[name];
            }
            return string.Empty;
        }
    }
}

