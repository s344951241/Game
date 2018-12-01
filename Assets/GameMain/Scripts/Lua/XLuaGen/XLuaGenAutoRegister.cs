#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter((luaenv, translator) => {
			    
				translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Type), SystemTypeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.DateTime), SystemDateTimeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Application), UnityEngineApplicationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Matrix4x4), UnityEngineMatrix4x4Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Rect), UnityEngineRectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WWW), UnityEngineWWWWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.MainModule), UnityEngineParticleSystemMainModuleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem.MinMaxCurve), UnityEngineParticleSystemMinMaxCurveWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Input), UnityEngineInputWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameFramework.ReferencePool), GameFrameworkReferencePoolWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameFramework.Utility.Assembly), GameFrameworkUtilityAssemblyWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameFramework.Utility.Converter), GameFrameworkUtilityConverterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameFramework.Utility.Json), GameFrameworkUtilityJsonWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameFramework.Utility.Nullable), GameFrameworkUtilityNullableWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameFramework.Utility.Path), GameFrameworkUtilityPathWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameFramework.Utility.Profiler), GameFrameworkUtilityProfilerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameFramework.Utility.Random), GameFrameworkUtilityRandomWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameFramework.Utility.Text), GameFrameworkUtilityTextWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameFramework.Utility.Verifier), GameFrameworkUtilityVerifierWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameFramework.Utility.Zip), GameFrameworkUtilityZipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityExtension), UnityExtensionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.Log), UnityGameFrameworkRuntimeLogWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.BaseComponent), UnityGameFrameworkRuntimeBaseComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.ConfigComponent), UnityGameFrameworkRuntimeConfigComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.DataNodeComponent), UnityGameFrameworkRuntimeDataNodeComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.DataTableComponent), UnityGameFrameworkRuntimeDataTableComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.DebuggerComponent), UnityGameFrameworkRuntimeDebuggerComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.DownloadComponent), UnityGameFrameworkRuntimeDownloadComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.EntityComponent), UnityGameFrameworkRuntimeEntityComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.EventComponent), UnityGameFrameworkRuntimeEventComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.FsmComponent), UnityGameFrameworkRuntimeFsmComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.GameFrameworkComponent), UnityGameFrameworkRuntimeGameFrameworkComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LocalizationComponent), UnityGameFrameworkRuntimeLocalizationComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.NetworkComponent), UnityGameFrameworkRuntimeNetworkComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.ObjectPoolComponent), UnityGameFrameworkRuntimeObjectPoolComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.ProcedureComponent), UnityGameFrameworkRuntimeProcedureComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.ResourceComponent), UnityGameFrameworkRuntimeResourceComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.SceneComponent), UnityGameFrameworkRuntimeSceneComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.SettingComponent), UnityGameFrameworkRuntimeSettingComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.SoundComponent), UnityGameFrameworkRuntimeSoundComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.UIComponent), UnityGameFrameworkRuntimeUIComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.WebRequestComponent), UnityGameFrameworkRuntimeWebRequestComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.CloseUIFormCompleteEventArgs), UnityGameFrameworkRuntimeCloseUIFormCompleteEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.DownloadFailureEventArgs), UnityGameFrameworkRuntimeDownloadFailureEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.DownloadStartEventArgs), UnityGameFrameworkRuntimeDownloadStartEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.DownloadSuccessEventArgs), UnityGameFrameworkRuntimeDownloadSuccessEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.DownloadUpdateEventArgs), UnityGameFrameworkRuntimeDownloadUpdateEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.HideEntityCompleteEventArgs), UnityGameFrameworkRuntimeHideEntityCompleteEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LoadConfigDependencyAssetEventArgs), UnityGameFrameworkRuntimeLoadConfigDependencyAssetEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LoadConfigFailureEventArgs), UnityGameFrameworkRuntimeLoadConfigFailureEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LoadConfigSuccessEventArgs), UnityGameFrameworkRuntimeLoadConfigSuccessEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LoadConfigUpdateEventArgs), UnityGameFrameworkRuntimeLoadConfigUpdateEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LoadDataTableDependencyAssetEventArgs), UnityGameFrameworkRuntimeLoadDataTableDependencyAssetEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LoadDataTableFailureEventArgs), UnityGameFrameworkRuntimeLoadDataTableFailureEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LoadDataTableSuccessEventArgs), UnityGameFrameworkRuntimeLoadDataTableSuccessEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LoadDataTableUpdateEventArgs), UnityGameFrameworkRuntimeLoadDataTableUpdateEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LoadDictionaryDependencyAssetEventArgs), UnityGameFrameworkRuntimeLoadDictionaryDependencyAssetEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LoadDictionaryFailureEventArgs), UnityGameFrameworkRuntimeLoadDictionaryFailureEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LoadDictionarySuccessEventArgs), UnityGameFrameworkRuntimeLoadDictionarySuccessEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LoadDictionaryUpdateEventArgs), UnityGameFrameworkRuntimeLoadDictionaryUpdateEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LoadSceneDependencyAssetEventArgs), UnityGameFrameworkRuntimeLoadSceneDependencyAssetEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LoadSceneFailureEventArgs), UnityGameFrameworkRuntimeLoadSceneFailureEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LoadSceneSuccessEventArgs), UnityGameFrameworkRuntimeLoadSceneSuccessEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.LoadSceneUpdateEventArgs), UnityGameFrameworkRuntimeLoadSceneUpdateEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.NetworkClosedEventArgs), UnityGameFrameworkRuntimeNetworkClosedEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.NetworkConnectedEventArgs), UnityGameFrameworkRuntimeNetworkConnectedEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.NetworkCustomErrorEventArgs), UnityGameFrameworkRuntimeNetworkCustomErrorEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.NetworkErrorEventArgs), UnityGameFrameworkRuntimeNetworkErrorEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.NetworkMissHeartBeatEventArgs), UnityGameFrameworkRuntimeNetworkMissHeartBeatEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.OpenUIFormDependencyAssetEventArgs), UnityGameFrameworkRuntimeOpenUIFormDependencyAssetEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.OpenUIFormFailureEventArgs), UnityGameFrameworkRuntimeOpenUIFormFailureEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.OpenUIFormSuccessEventArgs), UnityGameFrameworkRuntimeOpenUIFormSuccessEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.OpenUIFormUpdateEventArgs), UnityGameFrameworkRuntimeOpenUIFormUpdateEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs), UnityGameFrameworkRuntimePlaySoundDependencyAssetEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.PlaySoundFailureEventArgs), UnityGameFrameworkRuntimePlaySoundFailureEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.PlaySoundSuccessEventArgs), UnityGameFrameworkRuntimePlaySoundSuccessEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.PlaySoundUpdateEventArgs), UnityGameFrameworkRuntimePlaySoundUpdateEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs), UnityGameFrameworkRuntimeResourceUpdateChangedEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.ResourceUpdateFailureEventArgs), UnityGameFrameworkRuntimeResourceUpdateFailureEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.ResourceUpdateStartEventArgs), UnityGameFrameworkRuntimeResourceUpdateStartEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.ResourceUpdateSuccessEventArgs), UnityGameFrameworkRuntimeResourceUpdateSuccessEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.ShowEntityDependencyAssetEventArgs), UnityGameFrameworkRuntimeShowEntityDependencyAssetEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.ShowEntityFailureEventArgs), UnityGameFrameworkRuntimeShowEntityFailureEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.ShowEntitySuccessEventArgs), UnityGameFrameworkRuntimeShowEntitySuccessEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.ShowEntityUpdateEventArgs), UnityGameFrameworkRuntimeShowEntityUpdateEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.UnloadSceneFailureEventArgs), UnityGameFrameworkRuntimeUnloadSceneFailureEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.UnloadSceneSuccessEventArgs), UnityGameFrameworkRuntimeUnloadSceneSuccessEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.WebRequestFailureEventArgs), UnityGameFrameworkRuntimeWebRequestFailureEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.WebRequestStartEventArgs), UnityGameFrameworkRuntimeWebRequestStartEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityGameFramework.Runtime.WebRequestSuccessEventArgs), UnityGameFrameworkRuntimeWebRequestSuccessEventArgsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CusEncoding.EncodingType), CusEncodingEncodingTypeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(CusEncoding.EncodingUtil), CusEncodingEncodingUtilWrap.__Register);
				
				
				
			});
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
