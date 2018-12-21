using GameFramework;
using GameFramework.Event;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace Game
{
    public class ProcedurePreload : ProcedureBase
    {
        private Dictionary<string, bool> m_LoadedFlag = new Dictionary<string, bool>();

        public override bool UseNativeDialog
        {
            get
            {
                return true;
            }
        }

        protected internal override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);

            GameEntry.Event.Subscribe(LoadConfigSuccessEventArgs.EventId, OnLoadConfigSuccess);
            GameEntry.Event.Subscribe(LoadConfigFailureEventArgs.EventId, OnLoadConfigFailure);
            GameEntry.Event.Subscribe(LoadDataTableSuccessEventArgs.EventId, OnLoadDataTableSuccess);
            GameEntry.Event.Subscribe(LoadDataTableFailureEventArgs.EventId, OnLoadDataTableFailure);
            GameEntry.Event.Subscribe(LoadDictionarySuccessEventArgs.EventId, OnLoadDictionarySuccess);
            GameEntry.Event.Subscribe(LoadDictionaryFailureEventArgs.EventId, OnLoadDictionaryFailure);

            m_LoadedFlag.Clear();

            PreloadResources();
        }

        protected internal override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
        {
            Log.Info("Procedure preload duration: {0:F2} seconds.", procedureOwner.CurrentStateTime);

            if (GameEntry.Event.Check(LoadConfigSuccessEventArgs.EventId, OnLoadConfigSuccess))
            {
                GameEntry.Event.Unsubscribe(LoadConfigSuccessEventArgs.EventId, OnLoadConfigSuccess);
            }

            if (GameEntry.Event.Check(LoadConfigFailureEventArgs.EventId, OnLoadConfigFailure))
            {
                GameEntry.Event.Unsubscribe(LoadConfigFailureEventArgs.EventId, OnLoadConfigFailure);
            }

            if (GameEntry.Event.Check(LoadDataTableSuccessEventArgs.EventId, OnLoadDataTableSuccess))
            {
                GameEntry.Event.Unsubscribe(LoadDataTableSuccessEventArgs.EventId, OnLoadDataTableSuccess);
            }

            if (GameEntry.Event.Check(LoadDataTableFailureEventArgs.EventId, OnLoadDataTableFailure))
            {
                GameEntry.Event.Unsubscribe(LoadDataTableFailureEventArgs.EventId, OnLoadDataTableFailure);
            }

            if (GameEntry.Event.Check(LoadDictionarySuccessEventArgs.EventId, OnLoadDictionarySuccess))
            {
                GameEntry.Event.Unsubscribe(LoadDictionarySuccessEventArgs.EventId, OnLoadDictionarySuccess);
            }

            if (GameEntry.Event.Check(LoadDictionaryFailureEventArgs.EventId, OnLoadDictionaryFailure))
            {
                GameEntry.Event.Unsubscribe(LoadDictionaryFailureEventArgs.EventId, OnLoadDictionaryFailure);
            }

            GameEntry.Lua.StartVM();

            base.OnLeave(procedureOwner, isShutdown);
        }

        protected internal override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

            IEnumerator<bool> iter = m_LoadedFlag.Values.GetEnumerator();
            while (iter.MoveNext())
            {
                if (!iter.Current)
                {
                    return;
                }
            }
            //if (!GameEntry.Shader.IsAllShadersLoaded)
            //{
            //    return;
            //}
            if (!GameEntry.Table.IsAllTablesLoaded)
            {
                return;
            }
            if (!GameEntry.Lua.IsAllLuaScriptsLoaded)
            {
                return;
            }
            ChangeState<ProcedureMain>(procedureOwner);
            //ChangeState<ProcedureConnectServer>(procedureOwner);
#if UNITY_EDITOR

            //ChangeState<ProcedureConnectLoginServer>(procedureOwner);

#else
            //ChangeState<ProcedureConnectLoginServer>(procedureOwner);
#endif
        }

        private void PreloadResources()
        {
            Log.Error("进入预加载");
            // Preload configs
            //LoadConfig("GlobalConfig");

            // Preload data tables
            //LoadDataTable("DemoVO");
            //LoadDataTable("SkillVO");
            //LoadDataTable("UIPanelVO");

            GameEntry.Table.LoadTables();
            // Preload lua scripts
            GameEntry.Lua.LoadScripts();

            // Preload dictionaries
            //LoadDictionary("Common");
            //LoadDictionary("Mission");

            // Preload shader
            //GameEntry.Shader.StartLoadShaders();


            //GameEntry.Indicator.PrepareAssets();

        }

        private void LoadConfig(string configName)
        {
            m_LoadedFlag.Add(string.Format("Config.{0}", configName), false);
            GameEntry.Config.LoadConfig(configName, this);
        }

        private void LoadDataTable(string dataTableName)
        {
            m_LoadedFlag.Add(string.Format("DataTable.{0}", dataTableName), false);
            //GameEntry.DataTable.LoadDataTable(dataTableName, this);

        }

        private void LoadDictionary(string dictionaryName)
        {
            m_LoadedFlag.Add(string.Format("Dictionary.{0}", dictionaryName), false);
            GameEntry.Localization.LoadDictionary(dictionaryName, this);
        }

        private void OnLoadConfigSuccess(object sender, GameEventArgs e)
        {
            LoadConfigSuccessEventArgs ne = (LoadConfigSuccessEventArgs)e;
            if (ne.UserData != this)
            {
                return;
            }

            m_LoadedFlag[string.Format("Config.{0}", ne.ConfigName)] = true;
            Log.Info("Load config '{0}' OK.", ne.ConfigName);
        }

        private void OnLoadConfigFailure(object sender, GameEventArgs e)
        {
            LoadConfigFailureEventArgs ne = (LoadConfigFailureEventArgs)e;
            if (ne.UserData != this)
            {
                return;
            }

            Log.Error("Can not load config '{0}' from '{1}' with error message '{2}'.", ne.ConfigName, ne.ConfigAssetName, ne.ErrorMessage);
        }

        private void OnLoadDataTableSuccess(object sender, GameEventArgs e)
        {
            LoadDataTableSuccessEventArgs ne = (LoadDataTableSuccessEventArgs)e;
            if (ne.UserData != this)
            {
                return;
            }

            m_LoadedFlag[string.Format("DataTable.{0}", ne.DataTableName)] = true;
            Log.Info("Load data table '{0}' OK.", ne.DataTableName);
        }

        private void OnLoadDataTableFailure(object sender, GameEventArgs e)
        {
            LoadDataTableFailureEventArgs ne = (LoadDataTableFailureEventArgs)e;
            if (ne.UserData != this)
            {
                return;
            }

            Log.Error("Can not load data table '{0}' from '{1}' with error message '{2}'.", ne.DataTableName, ne.DataTableAssetName, ne.ErrorMessage);
        }

        private void OnLoadDictionarySuccess(object sender, GameEventArgs e)
        {
            LoadDictionarySuccessEventArgs ne = (LoadDictionarySuccessEventArgs)e;
            if (ne.UserData != this)
            {
                return;
            }

            m_LoadedFlag[string.Format("Dictionary.{0}", ne.DictionaryName)] = true;
            Log.Info("Load dictionary '{0}' OK.", ne.DictionaryName);
        }

        private void OnLoadDictionaryFailure(object sender, GameEventArgs e)
        {
            LoadDictionaryFailureEventArgs ne = (LoadDictionaryFailureEventArgs)e;
            if (ne.UserData != this)
            {
                return;

            }
            Log.Error("Can not load dictionary '{0}' from '{1}' with error message '{2}'.", ne.DictionaryName, ne.DictionaryAssetName, ne.ErrorMessage);
        }
    }
}
