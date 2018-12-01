using GameFramework;
using GameFramework.Resource;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityGameFramework.Runtime;
using XLua;

namespace Game
{
    [DisallowMultipleComponent]
    public class LuaComponent : GameFrameworkComponent
    {
        private const string LuaScriptListFileName = "Assets/GameMain/LuaScripts/LuaScriptList.txt";

        private LoadAssetCallbacks _LoadLuaScriptListCallBacks = null;
        private Dictionary<string, bool> _loadedFlags = new Dictionary<string, bool>();

        private readonly Dictionary<string, byte[]> _luaScriptCache = new Dictionary<string, byte[]>();
        private LoadAssetCallbacks _loadLuaScriptCallBacks = null;

        private static LuaEnv _luaEnv = null;
        private LuaTable _luaTable = null;
        private LuaTable _luaMetaTable = null;

        private Action _luaOnStart = null;
        private Action<float, float> _luaOnUpdate = null;
        private Action<float, float> _luaOnLateUpdate = null;
        private Action<bool> _luaOnApplicationPause = null;
        private Action _luaOnApplicationQuit = null;
        private Action _luaOnDestroy = null;

        private float _lastGCTime = 0;
        private readonly float _GCInterval = 1;


        public bool IsAllLuaScriptsLoaded
        {
            get
            {
                if (!GameEntry.Base.EditorResourceMode && _loadedFlags.Count<=0)
                {
                    return false;
                }

                foreach (KeyValuePair<string, bool> loadedFlag in _loadedFlags)
                {
                    if (!loadedFlag.Value)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public void StartVM()
        {
            _luaEnv = new LuaEnv();
            _luaEnv.AddLoader(CustomLuaScriptLoader);

            if (_luaMetaTable == null)
            {
                _luaMetaTable = _luaEnv.NewTable();
                _luaMetaTable.Set("__index", _luaEnv.Global);
            }

            if (_luaTable == null)
            {
                _luaTable = NewTable();
                DoScript("LuaMain", "LuaComponent", _luaTable);

                _luaTable.Get("OnStart", out _luaOnStart);
                _luaTable.Get("OnUpdate", out _luaOnUpdate);
                _luaTable.Get("OnLateUpdate", out _luaOnLateUpdate);
                _luaTable.Get("OnApplicationPause", out _luaOnApplicationPause);
                _luaTable.Get("OnApplicationQuit", out _luaOnApplicationQuit);
                _luaTable.Get("OnDestroy", out _luaOnDestroy);
            }

            if (_luaOnStart != null)
            {
                _luaOnStart();
            }
        }

        public LuaTable NewTable()
        {
            if (_luaEnv == null)
            {
                Log.Error("LuaEnv is invalid.");
                return null;
            }
            if (_luaMetaTable == null)
            {
                Log.Error("LuaMetaTabl is invalid.");
                return null;
            }
            LuaTable luaTable = _luaEnv.NewTable();
            luaTable.SetMetaTable(_luaMetaTable);
            return luaTable;
        }
        public void LoadScripts()
        {
            GameEntry.Resource.LoadAsset(LuaScriptListFileName, Constant.AssetPriority.LuaScriptAsset, _LoadLuaScriptListCallBacks);
        }

        public object[] DoScript(string luaScriptName, string chunkName, LuaTable env)
        {
            if (_luaEnv == null)
            {
                Log.Error("LuaEnv is invalid.");
                return null;
            }
            if (string.IsNullOrEmpty(luaScriptName))
            {
                Log.Error("Lua script name is invalid.");
                return null;
            }
            byte[] luaScriptBytes = null;
            if (!_luaScriptCache.TryGetValue(luaScriptName, out luaScriptBytes))
            {
                Log.Warning("Can not find lua script '{0}', please LoadScript first.", luaScriptName);
                return null;
            }
            return _luaEnv.DoString(luaScriptBytes, chunkName, env);
        }
        // Use this for initialization
        void Start()
        {
            _LoadLuaScriptListCallBacks = new LoadAssetCallbacks(LoadLuaScriptListSuccessCallback, LoadLuaScriptListFailureCallback);
            _loadLuaScriptCallBacks = new LoadAssetCallbacks(LoadLuaScriptSuccessCallback, LoadLuaScriptFailureCallback);

        }
        private void Update()
        {
            if (_luaOnUpdate != null)
            {
                _luaOnUpdate(Time.deltaTime, Time.unscaledDeltaTime);
            }

            if (_luaEnv != null && Time.time - _lastGCTime > _GCInterval)
            {
                _luaEnv.Tick();
                _lastGCTime = Time.time;
            }
        }
        private void LateUpdate()
        {
            if (_luaOnLateUpdate != null)
            {
                _luaOnLateUpdate(Time.deltaTime, Time.unscaledDeltaTime);
            }
        }
        private void OnApplicationPause(bool pause)
        {
            if (_luaOnApplicationPause != null)
            {
                _luaOnApplicationPause(pause);
            }
        }
        private void OnApplicationQuit()
        {
            if (_luaOnApplicationQuit != null)
            {
                _luaOnApplicationQuit();
            }
        }
        private void OnDestroy()
        {
            if (_luaOnDestroy != null)
            {
                _luaOnDestroy();
            }
            if(_luaMetaTable!=null)
            {
                try
                {
                    _luaMetaTable.Dispose();
                }
                finally {
                    _luaMetaTable = null;
                }
            }
            if (_luaTable != null)
            {
                try
                {
                    _luaTable.Dispose();
                }
                finally {
                    _luaTable = null;
                }
            }
            _luaScriptCache.Clear();
            _luaOnStart = null;
            _luaOnUpdate = null;
            _luaOnLateUpdate = null;
            _luaOnApplicationPause = null;
            _luaOnApplicationQuit = null;
            _luaOnDestroy = null;

            if (_luaEnv != null)
            {
                try
                {
                    _luaEnv.Dispose();
                }
                finally {
                    _luaEnv = null;
                }
            }
        }

        private byte[] CustomLuaScriptLoader(ref string luaScriptName)
        {
            byte[] luaScriptBytes = null;
            if (!_luaScriptCache.TryGetValue(luaScriptName, out luaScriptBytes))
            {
                Log.Warning("Can not find lua script '{0}'.", luaScriptName);
                return null;
            }
            return luaScriptBytes;
        }
        private void LoadScript(string luaScriptName, object userData = null)
        {
            if (string.IsNullOrEmpty(luaScriptName))
            {
                Log.Warning("Lua script name is invalid.");
                return;
            }

            string luaScriptAssetName = AssetUtility.GetLuaScriptAsset(luaScriptName);
            if (GameEntry.Base.EditorResourceMode)
            {
                if (!File.Exists(luaScriptAssetName))
                {
                    Log.Error("Can not find lua script '{0}'.", luaScriptAssetName);
                    return;
                }

                InternalLoadLuaScript(luaScriptName, luaScriptAssetName, File.ReadAllBytes(luaScriptAssetName), 0f, userData);
            }
            else
            {
                _loadedFlags.Add(luaScriptName, false);
                GameEntry.Resource.LoadAsset(luaScriptAssetName, Constant.AssetPriority.LuaScriptAsset,_loadLuaScriptCallBacks, new LuaScriptInfo(luaScriptName, userData));
            }
        }

#if UNITY_EDITOR
        [SerializeField]
        private bool _luaEditMode = false;

        public bool LuaEditMode
        {
            get {
                return _luaEditMode;
            }
        }
        /// <summary>
        /// 重新加载指定的Lua脚本,只在编辑器状态下可用
        /// </summary>
        public void LoadScriptInEditor(string luaScriptName)
        {
            if (GameEntry.Base.EditorResourceMode)
            {
                string luaScriptAssetName = AssetUtility.GetLuaScriptAsset(luaScriptName);
                if (!File.Exists(luaScriptAssetName))
                {
                    Log.Error("Can not find lua script '{0}'.", luaScriptAssetName);
                    return;
                }
                InternalLoadLuaScript(luaScriptName, luaScriptAssetName, File.ReadAllBytes(luaScriptAssetName), 0f, null);
                _luaEnv.DoString(Utility.Text.Format("package.loaded[\"{0}\"] = nil package.preload[\"{1}\"] = nil", luaScriptName, luaScriptName), luaScriptName);
                Debug.Log(luaScriptName);
            }
        }

        public void ReloadScriptInEditor(string luaScriptName)
        {
            if (GameEntry.Base.EditorResourceMode && _luaEditMode)
            {
                string luaScriptAssetName = AssetUtility.GetLuaScriptAsset(luaScriptName);
                if (!File.Exists(luaScriptAssetName))
                {
                    Log.Error("Can not find lua script '{0}'.", luaScriptAssetName);
                    return;
                }
                InternalLoadLuaScript(luaScriptName, luaScriptAssetName, File.ReadAllBytes(luaScriptAssetName), 0f, null);
                _luaEnv.DoString(Utility.Text.Format("package.loaded[\"{0}\"] = nil package.preload[\"{1}\"] = nil", luaScriptName, luaScriptName), luaScriptName);
                Debug.Log(luaScriptName);
            }
        }
#endif
       
        private void LoadLuaScriptListSuccessCallback(string luaScriptListAssetName, object asset, float duration, object userData)
        {
            TextAsset luaScriptList = asset as TextAsset;
            if (luaScriptList == null)
            {
                Log.Error("Lua component load lua script list asset failure, which is not a TextAsset.");
                return;
            }

            string[] LineSplit = new string[] { "\r\n", "\r", "\n" };
            string[] luaScriptNames = luaScriptList.text.Split(LineSplit, StringSplitOptions.None);
            for (int i = 0; i < luaScriptNames.Length; i++)
            {
                LoadScript(luaScriptNames[i]);
            }

            GameEntry.Resource.UnloadAsset(luaScriptList);
        }
        private void LoadLuaScriptListFailureCallback(string luaScriptListAssetName, LoadResourceStatus status, string errorMessage, object userData)
        {
            Log.Error("Lua component load lua script list asset failure, status is '{0}', error message is '{1}'.", status.ToString(), errorMessage);
        }

        private void LoadLuaScriptSuccessCallback(string luaScriptAssetName, object asset, float duration, object userData)
        {
            TextAsset luaScriptAsset = asset as TextAsset;
            if (luaScriptAsset == null)
            {
                Log.Warning("Lua script asset '{0}' is invalid.", luaScriptAssetName);
                return;
            }

            byte[] bytes = new byte[luaScriptAsset.bytes.Length];
            luaScriptAsset.bytes.CopyTo(bytes, 0);
            GameEntry.Resource.UnloadAsset(luaScriptAsset);

            LuaScriptInfo luaScriptInfo = (LuaScriptInfo)userData;
            InternalLoadLuaScript(luaScriptInfo.LuaScriptName, luaScriptAssetName, bytes, duration, luaScriptInfo.UserData);

            _loadedFlags[luaScriptInfo.LuaScriptName] = true;
        }
        private void LoadLuaScriptFailureCallback(string luaScriptAssetName, LoadResourceStatus status, string errorMessage, object userData)
        {
            Log.Error("Load lua script failure, asset name '{0}', status '{1}', error message '{2}'.", luaScriptAssetName, status.ToString(), errorMessage);
        }
        private void InternalLoadLuaScript(string luaScriptName, string luaScriptAssetName, byte[] bytes, float duration, object userData)
        {
            if (bytes.Length != 0)
            {
                if (bytes[0] == 239 && bytes[1] == 187 && bytes[2] == 191)
                {
                    // 处理UFT-8 BOM头
                    bytes[0] = bytes[1] = bytes[2] = 32;
                }
                _luaScriptCache[luaScriptName] = bytes;
            }
            Log.Info("Load lua script '{0}' OK, use '{1:F2}' seconds.", luaScriptName, duration);
        }

        private sealed class LuaScriptInfo
        {
            private readonly string _luaScriptName;
            private readonly object _userData;

            public LuaScriptInfo(string luaScriptName, object userData)
            {
                _luaScriptName = luaScriptName;
                _userData = userData;
            }

            public string LuaScriptName
            {
                get
                {
                    return _luaScriptName;
                }
            }

            public object UserData
            {
                get
                {
                    return _userData;
                }
            }
        }
    }
}

