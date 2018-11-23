using GameFramework;
using GameFramework.Event;
using GameFramework.Resource;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace Game
{
    public class ProcedureCheckVersion : ProcedureBase
    {
        private bool m_LatestVersionComplete = false;
        private VersionInfo m_VersionInfo = null;
        private UpdateVersionListCallbacks m_UpdateVersionListCallbacks = null;
        public override bool UseNativeDialog
        {
            get
            {
                return true;
            }
        }
        //protected override void OnInit(ProcedureOwner procedureOwner)
        //{
        //    base.OnInit(procedureOwner);

        //    m_UpdateVersionListCallbacks = new UpdateVersionListCallbacks(OnUpdateVersionListSuccess, OnUpdateVersionListFailure);
        //}
        protected internal override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);

            m_LatestVersionComplete = false;
            m_VersionInfo = null;

            GameEntry.Event.Subscribe(WebRequestSuccessEventArgs.EventId, OnWebRequestSuccess);
            GameEntry.Event.Subscribe(WebRequestFailureEventArgs.EventId, OnWebRequestFailure);

            switch (GameEntry.Resource.ResourceMode)
            {
                case ResourceMode.Package:
                    GameEntry.Resource.InitResources(OnInitResourcesComplete);
                    break;
                case ResourceMode.Updatable:
                    RequestVersion();
                    break;
                default:
                    Log.Error("Invalid resource mode.");
                    return;
            }
        }

        protected internal override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
        {
            GameEntry.Event.Unsubscribe(WebRequestSuccessEventArgs.EventId, OnWebRequestSuccess);
            GameEntry.Event.Unsubscribe(WebRequestFailureEventArgs.EventId, OnWebRequestFailure);
            base.OnLeave(procedureOwner, isShutdown);
        }

        protected internal override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

            if (!m_LatestVersionComplete)
            {
                return;
            }
            switch (GameEntry.Resource.ResourceMode)
            {
                case ResourceMode.Package:
                    ChangeState<ProcedurePreload>(procedureOwner);
                    break;
                case ResourceMode.Updatable:
                    ChangeState<ProcedureUpdateResource>(procedureOwner);
                    break;
                default:
                    Log.Error("Invalid resource mode.");
                    return;
            }
        }

        private void GotoUpdateApp(object userData)
        {
            string url = null;
#if UNITY_EDITOR
            url = GameEntry.BuiltinData.BuildInfo.StandaloneAppUrl;
#elif UNITY_IOS
            url = GameEntry.BuiltinData.BuildInfo.IosAppUrl;
#elif UNITY_ANDROID
            url = GameEntry.BuiltinData.BuildInfo.AndroidAppUrl;
#else
            url = GameEntry.BuiltinData.BuildInfo.StandaloneAppUrl;
#endif
            Application.OpenURL(url);
        }

        private void RequestVersion()
        {
            Dictionary<string, string> systemInfo = new Dictionary<string, string>();
            GameEntry.SystemInfo.GenerateValues(systemInfo, null);

            WWWForm wwwForm = new WWWForm();
            foreach (KeyValuePair<string, string> i in systemInfo)
            {
                wwwForm.AddField(i.Key, WebUtility.EscapeString(i.Value));
            }

            GameEntry.WebRequest.AddWebRequest(GameEntry.BuiltinData.BuildInfo.CheckVersionUrl, wwwForm, this);
        }

        private void UpdateVersion()
        {
            if (GameEntry.Resource.CheckVersionList(m_VersionInfo.InternalResourceVersion) == CheckVersionListResult.Updated)
            {
                m_LatestVersionComplete = true;
            }
            else
            {
                GameEntry.Resource.UpdateVersionList(m_VersionInfo.VersionListLength, m_VersionInfo.VersionListHashCode, m_VersionInfo.VersionListZipLength, m_VersionInfo.VersionListZipHashCode, m_UpdateVersionListCallbacks);
            }
        }

        private void OnWebRequestSuccess(object sender, GameEventArgs e)
        {
            WebRequestSuccessEventArgs ne = (WebRequestSuccessEventArgs)e;
            if (ne.UserData != this)
            {
                return;
            }
            string str = Utility.Converter.GetString(ne.GetWebResponseBytes());
            Debug.LogError(str);
            m_VersionInfo = Utility.Json.ToObject<VersionInfo>(str);
            if (m_VersionInfo == null)
            {
                Log.Error("Parse VersionInfo failure.");
                return;
            }

            Log.Info("Latest game version is '{0}', local game version is '{1}'.", m_VersionInfo.LatestGameVersion, Version.GameVersion);

            if (m_VersionInfo.ForceGameUpdate)
            {
                //GameEntry.UI.OpenDialog(new DialogParams
                //{
                //    Mode = 2,
                //    Title = GameEntry.Localization.GetString("ForceUpdate.Title"),
                //    Message = GameEntry.Localization.GetString("ForceUpdate.Message"),
                //    ConfirmText = GameEntry.Localization.GetString("ForceUpdate.UpdateButton"),
                //    OnClickConfirm = GotoUpdateApp,
                //    CancelText = GameEntry.Localization.GetString("ForceUpdate.QuitButton"),
                //    OnClickCancel = delegate (object userData) { UnityGameFramework.Runtime.GameEntry.Shutdown(ShutdownType.Quit); },
                //});
                Debug.LogError("强更");
                return;
            }

            GameEntry.Resource.UpdatePrefixUri = Utility.Path.GetCombinePath(m_VersionInfo.GameUpdateUrl, GetResourceVersionName(), GetPlatformPath());
            UpdateVersion();
        }



        private void OnWebRequestFailure(object sender, GameEventArgs e)
        {
            WebRequestFailureEventArgs ne = (WebRequestFailureEventArgs)e;
            if (ne.UserData != this)
            {
                return;
            }

            Log.Warning("Check version failure, error message '{0}'.", ne.ErrorMessage);
        }



        private void OnResourceInitComplete(object sender, GameEventArgs e)
        {
            m_LatestVersionComplete = true;
            Log.Info("Init resource complete.");
        }

        private void OnInitResourcesComplete()
        {
            m_LatestVersionComplete = true;
            Log.Info("Init resources complete.");
        }

        private string GetResourceVersionName()
        {
            string[] splitApplicableGameVersion = GameEntry.SystemInfo.Software.GameVersion.Split('.');
            if (splitApplicableGameVersion.Length != 3)
            {
                return string.Empty;
            }

            return string.Format("{0}_{1}_{2}_{3}", splitApplicableGameVersion[0], splitApplicableGameVersion[1], splitApplicableGameVersion[2], m_VersionInfo.InternalResourceVersion.ToString());
        }

        private string GetPlatformPath()
        {
            switch (Application.platform)
            {
                case RuntimePlatform.WindowsEditor:
                case RuntimePlatform.WindowsPlayer:
                    return "windows";
                case RuntimePlatform.OSXEditor:
                case RuntimePlatform.OSXPlayer:
                    return "osx";
                case RuntimePlatform.IPhonePlayer:
                    return "ios";
                case RuntimePlatform.Android:
                    return "android";
                case RuntimePlatform.WSAPlayerX86:
                case RuntimePlatform.WSAPlayerX64:
                case RuntimePlatform.WSAPlayerARM:
                    return "winstore";
                default:
                    return string.Empty;
            }
        }
    }
}
