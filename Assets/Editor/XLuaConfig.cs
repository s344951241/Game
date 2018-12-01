using System.Collections.Generic;
using XLua;

namespace Game.Editor
{
    public static class XLuaConfig
    {

        [CSObjectWrapEditor.GenPath]
        public static readonly string XluaGenPath = GameFramework.Utility.Path.GetCombinePath(UnityEngine.Application.dataPath, "GameMain/Scripts/Lua/XLuaGen/");

        [LuaCallCSharp]
        public static readonly List<System.Type> LuaCallCSharp = new List<System.Type>()
        {  
            #region System

            typeof(System.Delegate),
            typeof(System.Object),
            typeof(System.Type),
            typeof(System.DateTime),
            #endregion System

            #region UnityEngine

            typeof(UnityEngine.Application),
            typeof(UnityEngine.Behaviour),
            typeof(UnityEngine.Color),
            typeof(UnityEngine.Component),
            typeof(UnityEngine.GameObject),
            typeof(UnityEngine.MonoBehaviour),
            typeof(UnityEngine.Object),
            typeof(UnityEngine.Transform),
            typeof(UnityEngine.Vector2),
            typeof(UnityEngine.Vector3),
            typeof(UnityEngine.Vector4),
            typeof(UnityEngine.Quaternion),
            typeof(UnityEngine.Matrix4x4),
            typeof(UnityEngine.Rect),
            typeof(UnityEngine.WWW),
            typeof(UnityEngine.ParticleSystem),
            typeof(UnityEngine.ParticleSystem.MainModule),
            typeof(UnityEngine.ParticleSystem.MinMaxCurve),
            typeof(UnityEngine.Input),

            #endregion UnityEngine

            #region GameFramework

            typeof(GameFramework.ReferencePool),
            typeof(GameFramework.Utility.Assembly),
            typeof(GameFramework.Utility.Converter),
            typeof(GameFramework.Utility.Json),
            typeof(GameFramework.Utility.Nullable),
            typeof(GameFramework.Utility.Path),
            typeof(GameFramework.Utility.Profiler),
            typeof(GameFramework.Utility.Random),
            typeof(GameFramework.Utility.Text),
            typeof(GameFramework.Utility.Verifier),
            typeof(GameFramework.Utility.Zip),

            #endregion GameFramework
            
            #region UnityGameFramework

            typeof(UnityExtension),
            typeof(UnityGameFramework.Runtime.Log),
            typeof(UnityGameFramework.Runtime.BaseComponent),
            typeof(UnityGameFramework.Runtime.ConfigComponent),
            typeof(UnityGameFramework.Runtime.DataNodeComponent),
            typeof(UnityGameFramework.Runtime.DataTableComponent),
            typeof(UnityGameFramework.Runtime.DebuggerComponent),
            typeof(UnityGameFramework.Runtime.DownloadComponent),
            typeof(UnityGameFramework.Runtime.EntityComponent),
            typeof(UnityGameFramework.Runtime.EventComponent),
            typeof(UnityGameFramework.Runtime.FsmComponent),
            typeof(UnityGameFramework.Runtime.GameFrameworkComponent),
            typeof(UnityGameFramework.Runtime.LocalizationComponent),
            typeof(UnityGameFramework.Runtime.NetworkComponent),
            typeof(UnityGameFramework.Runtime.ObjectPoolComponent),
            typeof(UnityGameFramework.Runtime.ProcedureComponent),
            typeof(UnityGameFramework.Runtime.ResourceComponent),
            typeof(UnityGameFramework.Runtime.SceneComponent),
            typeof(UnityGameFramework.Runtime.SettingComponent),
            typeof(UnityGameFramework.Runtime.SoundComponent),
            typeof(UnityGameFramework.Runtime.UIComponent),
            typeof(UnityGameFramework.Runtime.WebRequestComponent),

            #endregion UnityGameFramework

            #region UnityGameFramework.Events

            typeof(UnityGameFramework.Runtime.CloseUIFormCompleteEventArgs),
            typeof(UnityGameFramework.Runtime.DownloadFailureEventArgs),
            typeof(UnityGameFramework.Runtime.DownloadStartEventArgs),
            typeof(UnityGameFramework.Runtime.DownloadSuccessEventArgs),
            typeof(UnityGameFramework.Runtime.DownloadUpdateEventArgs),
            typeof(UnityGameFramework.Runtime.HideEntityCompleteEventArgs),
            typeof(UnityGameFramework.Runtime.LoadConfigDependencyAssetEventArgs),
            typeof(UnityGameFramework.Runtime.LoadConfigFailureEventArgs),
            typeof(UnityGameFramework.Runtime.LoadConfigSuccessEventArgs),
            typeof(UnityGameFramework.Runtime.LoadConfigUpdateEventArgs),
            typeof(UnityGameFramework.Runtime.LoadDataTableDependencyAssetEventArgs),
            typeof(UnityGameFramework.Runtime.LoadDataTableFailureEventArgs),
            typeof(UnityGameFramework.Runtime.LoadDataTableSuccessEventArgs),
            typeof(UnityGameFramework.Runtime.LoadDataTableUpdateEventArgs),
            typeof(UnityGameFramework.Runtime.LoadDictionaryDependencyAssetEventArgs),
            typeof(UnityGameFramework.Runtime.LoadDictionaryFailureEventArgs),
            typeof(UnityGameFramework.Runtime.LoadDictionarySuccessEventArgs),
            typeof(UnityGameFramework.Runtime.LoadDictionaryUpdateEventArgs),
            typeof(UnityGameFramework.Runtime.LoadSceneDependencyAssetEventArgs),
            typeof(UnityGameFramework.Runtime.LoadSceneFailureEventArgs),
            typeof(UnityGameFramework.Runtime.LoadSceneSuccessEventArgs),
            typeof(UnityGameFramework.Runtime.LoadSceneUpdateEventArgs),
            typeof(UnityGameFramework.Runtime.NetworkClosedEventArgs),
            typeof(UnityGameFramework.Runtime.NetworkConnectedEventArgs),
            typeof(UnityGameFramework.Runtime.NetworkCustomErrorEventArgs),
            typeof(UnityGameFramework.Runtime.NetworkErrorEventArgs),
            typeof(UnityGameFramework.Runtime.NetworkMissHeartBeatEventArgs),
            typeof(UnityGameFramework.Runtime.OpenUIFormDependencyAssetEventArgs),
            typeof(UnityGameFramework.Runtime.OpenUIFormFailureEventArgs),
            typeof(UnityGameFramework.Runtime.OpenUIFormSuccessEventArgs),
            typeof(UnityGameFramework.Runtime.OpenUIFormUpdateEventArgs),
            typeof(UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs),
            typeof(UnityGameFramework.Runtime.PlaySoundFailureEventArgs),
            typeof(UnityGameFramework.Runtime.PlaySoundSuccessEventArgs),
            typeof(UnityGameFramework.Runtime.PlaySoundUpdateEventArgs),
            typeof(UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs),
            typeof(UnityGameFramework.Runtime.ResourceUpdateFailureEventArgs),
            typeof(UnityGameFramework.Runtime.ResourceUpdateStartEventArgs),
            typeof(UnityGameFramework.Runtime.ResourceUpdateSuccessEventArgs),
            typeof(UnityGameFramework.Runtime.ShowEntityDependencyAssetEventArgs),
            typeof(UnityGameFramework.Runtime.ShowEntityFailureEventArgs),
            typeof(UnityGameFramework.Runtime.ShowEntitySuccessEventArgs),
            typeof(UnityGameFramework.Runtime.ShowEntityUpdateEventArgs),
            typeof(UnityGameFramework.Runtime.UnloadSceneFailureEventArgs),
            typeof(UnityGameFramework.Runtime.UnloadSceneSuccessEventArgs),
            typeof(UnityGameFramework.Runtime.WebRequestFailureEventArgs),
            typeof(UnityGameFramework.Runtime.WebRequestStartEventArgs),
            typeof(UnityGameFramework.Runtime.WebRequestSuccessEventArgs),

            #endregion UnityGameFramework.Events

            #region CusEncoding

            typeof(CusEncoding.EncodingType),
            typeof(CusEncoding.EncodingUtil),

            #endregion CusEncoding
        };
        [CSharpCallLua]
        public static readonly List<System.Type> CSharpCallLua = new List<System.Type>()
        {
            typeof(System.Action),
            typeof(System.Action<bool>),
            typeof(System.Action<object>),
            typeof(System.Action<UnityEngine.GameObject>),
            typeof(System.Action<int, int>),
            typeof(System.Action<float, float>),
            typeof(System.Action<UnityEngine.GameObject, string>),
            typeof(System.EventHandler<GameFramework.Event.GameEventArgs>),
            typeof(System.Action<UnityEngine.GameObject, bool>),
            typeof(System.Func<object>),
            typeof(System.Func<object, object>),
            typeof(System.Func<object[], object>),
            typeof(System.Func<object[], float>),


            typeof(UnityEngine.Video.VideoPlayer.EventHandler),

         };


        // 黑名单
        [BlackList]
        public static readonly List<List<string>> BlackList = new List<List<string>>()
        {
            // 需要屏蔽的编辑器代码列在这里，避免打包编译错误。
            // 由于考虑到有可能需要把重载函数的其中一个重载列入黑名单，配置方式比较复杂。
            // 对于每个成员，在第一层List有一个条目，第二层List是个string的列表。
            // 第一个string是类型的全路径名，第二个string是成员名。
            // 如果成员是一个方法，还需要从第三个string开始，把其参数的类型全路径全列出来。
            // 例如：
            // new List<string>(){"UnityEngine.GameObject", "networkView"},
            // new List<string>(){"System.IO.FileInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
            new List<string>() {"UnityEngine.MonoBehaviour", "runInEditMode"},
            new List<string>() {"UnityEngine.WWW", "GetMovieTexture"},
            new List<string>() {"UIWidget", "showHandles"},
            new List<string>() {"UIWidget", "showHandlesWithMoveTool"},
            new List<string>() {"UIInput", "ProcessEvent", "UnityEngine.Event"},
            new List<string>() {"UnityEngine.Input", "IsJoystickPreconfigured", "System.String"},
        };
    }
}

