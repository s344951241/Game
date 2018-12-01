#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class UnityGameFrameworkRuntimeResourceComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityGameFramework.Runtime.ResourceComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 19, 27, 11);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetResourceMode", _m_SetResourceMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetCurrentVariant", _m_SetCurrentVariant);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDecryptResourceCallback", _m_SetDecryptResourceCallback);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnloadUnusedAssets", _m_UnloadUnusedAssets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ForceUnloadUnusedAssets", _m_ForceUnloadUnusedAssets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InitResources", _m_InitResources);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CheckVersionList", _m_CheckVersionList);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateVersionList", _m_UpdateVersionList);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CheckResources", _m_CheckResources);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateResources", _m_UpdateResources);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasAsset", _m_HasAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAsset", _m_LoadAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnloadAsset", _m_UnloadAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetResourceGroupReady", _m_GetResourceGroupReady);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetResourceGroupResourceCount", _m_GetResourceGroupResourceCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetResourceGroupReadyResourceCount", _m_GetResourceGroupReadyResourceCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetResourceGroupTotalLength", _m_GetResourceGroupTotalLength);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetResourceGroupTotalReadyLength", _m_GetResourceGroupTotalReadyLength);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetResourceGroupProgress", _m_GetResourceGroupProgress);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ReadOnlyPath", _g_get_ReadOnlyPath);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ReadWritePath", _g_get_ReadWritePath);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ResourceMode", _g_get_ResourceMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ReadWritePathType", _g_get_ReadWritePathType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CurrentVariant", _g_get_CurrentVariant);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UnloadUnusedAssetsInterval", _g_get_UnloadUnusedAssetsInterval);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ApplicableGameVersion", _g_get_ApplicableGameVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "InternalResourceVersion", _g_get_InternalResourceVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssetCount", _g_get_AssetCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ResourceCount", _g_get_ResourceCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ResourceGroupCount", _g_get_ResourceGroupCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UpdatePrefixUri", _g_get_UpdatePrefixUri);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UpdateRetryCount", _g_get_UpdateRetryCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UpdateWaitingCount", _g_get_UpdateWaitingCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UpdatingCount", _g_get_UpdatingCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LoadTotalAgentCount", _g_get_LoadTotalAgentCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LoadFreeAgentCount", _g_get_LoadFreeAgentCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LoadWorkingAgentCount", _g_get_LoadWorkingAgentCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LoadWaitingTaskCount", _g_get_LoadWaitingTaskCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssetAutoReleaseInterval", _g_get_AssetAutoReleaseInterval);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssetCapacity", _g_get_AssetCapacity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssetExpireTime", _g_get_AssetExpireTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssetPriority", _g_get_AssetPriority);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ResourceAutoReleaseInterval", _g_get_ResourceAutoReleaseInterval);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ResourceCapacity", _g_get_ResourceCapacity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ResourceExpireTime", _g_get_ResourceExpireTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ResourcePriority", _g_get_ResourcePriority);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "UnloadUnusedAssetsInterval", _s_set_UnloadUnusedAssetsInterval);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "UpdatePrefixUri", _s_set_UpdatePrefixUri);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "UpdateRetryCount", _s_set_UpdateRetryCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AssetAutoReleaseInterval", _s_set_AssetAutoReleaseInterval);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AssetCapacity", _s_set_AssetCapacity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AssetExpireTime", _s_set_AssetExpireTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AssetPriority", _s_set_AssetPriority);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ResourceAutoReleaseInterval", _s_set_ResourceAutoReleaseInterval);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ResourceCapacity", _s_set_ResourceCapacity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ResourceExpireTime", _s_set_ResourceExpireTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ResourcePriority", _s_set_ResourcePriority);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityGameFramework.Runtime.ResourceComponent __cl_gen_ret = new UnityGameFramework.Runtime.ResourceComponent();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ResourceComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetResourceMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    GameFramework.Resource.ResourceMode resourceMode;translator.Get(L, 2, out resourceMode);
                    
                    __cl_gen_to_be_invoked.SetResourceMode( resourceMode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCurrentVariant(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string currentVariant = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.SetCurrentVariant( currentVariant );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDecryptResourceCallback(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    GameFramework.Resource.DecryptResourceCallback decryptResourceCallback = translator.GetDelegate<GameFramework.Resource.DecryptResourceCallback>(L, 2);
                    
                    __cl_gen_to_be_invoked.SetDecryptResourceCallback( decryptResourceCallback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnloadUnusedAssets(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool performGCCollect = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.UnloadUnusedAssets( performGCCollect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForceUnloadUnusedAssets(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool performGCCollect = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.ForceUnloadUnusedAssets( performGCCollect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InitResources(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    GameFramework.Resource.InitResourcesCompleteCallback initResourcesCompleteCallback = translator.GetDelegate<GameFramework.Resource.InitResourcesCompleteCallback>(L, 2);
                    
                    __cl_gen_to_be_invoked.InitResources( initResourcesCompleteCallback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CheckVersionList(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int latestInternalResourceVersion = LuaAPI.xlua_tointeger(L, 2);
                    
                        GameFramework.Resource.CheckVersionListResult __cl_gen_ret = __cl_gen_to_be_invoked.CheckVersionList( latestInternalResourceVersion );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateVersionList(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int versionListLength = LuaAPI.xlua_tointeger(L, 2);
                    int versionListHashCode = LuaAPI.xlua_tointeger(L, 3);
                    int versionListZipLength = LuaAPI.xlua_tointeger(L, 4);
                    int versionListZipHashCode = LuaAPI.xlua_tointeger(L, 5);
                    GameFramework.Resource.UpdateVersionListCallbacks updateVersionListCallbacks = (GameFramework.Resource.UpdateVersionListCallbacks)translator.GetObject(L, 6, typeof(GameFramework.Resource.UpdateVersionListCallbacks));
                    
                    __cl_gen_to_be_invoked.UpdateVersionList( versionListLength, versionListHashCode, versionListZipLength, versionListZipHashCode, updateVersionListCallbacks );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CheckResources(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    GameFramework.Resource.CheckResourcesCompleteCallback checkResourcesCompleteCallback = translator.GetDelegate<GameFramework.Resource.CheckResourcesCompleteCallback>(L, 2);
                    
                    __cl_gen_to_be_invoked.CheckResources( checkResourcesCompleteCallback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateResources(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    GameFramework.Resource.UpdateResourcesCompleteCallback updateResourcesCompleteCallback = translator.GetDelegate<GameFramework.Resource.UpdateResourcesCompleteCallback>(L, 2);
                    
                    __cl_gen_to_be_invoked.UpdateResources( updateResourcesCompleteCallback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.HasAsset( assetName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<GameFramework.Resource.LoadAssetCallbacks>(L, 3)) 
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    GameFramework.Resource.LoadAssetCallbacks loadAssetCallbacks = (GameFramework.Resource.LoadAssetCallbacks)translator.GetObject(L, 3, typeof(GameFramework.Resource.LoadAssetCallbacks));
                    
                    __cl_gen_to_be_invoked.LoadAsset( assetName, loadAssetCallbacks );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<GameFramework.Resource.LoadAssetCallbacks>(L, 4)) 
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    int priority = LuaAPI.xlua_tointeger(L, 3);
                    GameFramework.Resource.LoadAssetCallbacks loadAssetCallbacks = (GameFramework.Resource.LoadAssetCallbacks)translator.GetObject(L, 4, typeof(GameFramework.Resource.LoadAssetCallbacks));
                    
                    __cl_gen_to_be_invoked.LoadAsset( assetName, priority, loadAssetCallbacks );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& translator.Assignable<GameFramework.Resource.LoadAssetCallbacks>(L, 4)) 
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    System.Type assetType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    GameFramework.Resource.LoadAssetCallbacks loadAssetCallbacks = (GameFramework.Resource.LoadAssetCallbacks)translator.GetObject(L, 4, typeof(GameFramework.Resource.LoadAssetCallbacks));
                    
                    __cl_gen_to_be_invoked.LoadAsset( assetName, assetType, loadAssetCallbacks );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<GameFramework.Resource.LoadAssetCallbacks>(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    GameFramework.Resource.LoadAssetCallbacks loadAssetCallbacks = (GameFramework.Resource.LoadAssetCallbacks)translator.GetObject(L, 3, typeof(GameFramework.Resource.LoadAssetCallbacks));
                    object userData = translator.GetObject(L, 4, typeof(object));
                    
                    __cl_gen_to_be_invoked.LoadAsset( assetName, loadAssetCallbacks, userData );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<GameFramework.Resource.LoadAssetCallbacks>(L, 5)) 
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    System.Type assetType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    int priority = LuaAPI.xlua_tointeger(L, 4);
                    GameFramework.Resource.LoadAssetCallbacks loadAssetCallbacks = (GameFramework.Resource.LoadAssetCallbacks)translator.GetObject(L, 5, typeof(GameFramework.Resource.LoadAssetCallbacks));
                    
                    __cl_gen_to_be_invoked.LoadAsset( assetName, assetType, priority, loadAssetCallbacks );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<GameFramework.Resource.LoadAssetCallbacks>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    int priority = LuaAPI.xlua_tointeger(L, 3);
                    GameFramework.Resource.LoadAssetCallbacks loadAssetCallbacks = (GameFramework.Resource.LoadAssetCallbacks)translator.GetObject(L, 4, typeof(GameFramework.Resource.LoadAssetCallbacks));
                    object userData = translator.GetObject(L, 5, typeof(object));
                    
                    __cl_gen_to_be_invoked.LoadAsset( assetName, priority, loadAssetCallbacks, userData );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& translator.Assignable<GameFramework.Resource.LoadAssetCallbacks>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    System.Type assetType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    GameFramework.Resource.LoadAssetCallbacks loadAssetCallbacks = (GameFramework.Resource.LoadAssetCallbacks)translator.GetObject(L, 4, typeof(GameFramework.Resource.LoadAssetCallbacks));
                    object userData = translator.GetObject(L, 5, typeof(object));
                    
                    __cl_gen_to_be_invoked.LoadAsset( assetName, assetType, loadAssetCallbacks, userData );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<GameFramework.Resource.LoadAssetCallbacks>(L, 5)&& translator.Assignable<object>(L, 6)) 
                {
                    string assetName = LuaAPI.lua_tostring(L, 2);
                    System.Type assetType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    int priority = LuaAPI.xlua_tointeger(L, 4);
                    GameFramework.Resource.LoadAssetCallbacks loadAssetCallbacks = (GameFramework.Resource.LoadAssetCallbacks)translator.GetObject(L, 5, typeof(GameFramework.Resource.LoadAssetCallbacks));
                    object userData = translator.GetObject(L, 6, typeof(object));
                    
                    __cl_gen_to_be_invoked.LoadAsset( assetName, assetType, priority, loadAssetCallbacks, userData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ResourceComponent.LoadAsset!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnloadAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object asset = translator.GetObject(L, 2, typeof(object));
                    
                    __cl_gen_to_be_invoked.UnloadAsset( asset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetResourceGroupReady(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string resourceGroupName = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.GetResourceGroupReady( resourceGroupName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetResourceGroupResourceCount(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string resourceGroupName = LuaAPI.lua_tostring(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetResourceGroupResourceCount( resourceGroupName );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetResourceGroupReadyResourceCount(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string resourceGroupName = LuaAPI.lua_tostring(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetResourceGroupReadyResourceCount( resourceGroupName );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetResourceGroupTotalLength(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string resourceGroupName = LuaAPI.lua_tostring(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetResourceGroupTotalLength( resourceGroupName );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetResourceGroupTotalReadyLength(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string resourceGroupName = LuaAPI.lua_tostring(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetResourceGroupTotalReadyLength( resourceGroupName );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetResourceGroupProgress(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string resourceGroupName = LuaAPI.lua_tostring(L, 2);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.GetResourceGroupProgress( resourceGroupName );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ReadOnlyPath(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.ReadOnlyPath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ReadWritePath(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.ReadWritePath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ResourceMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.ResourceMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ReadWritePathType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.ReadWritePathType);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CurrentVariant(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.CurrentVariant);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UnloadUnusedAssetsInterval(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.UnloadUnusedAssetsInterval);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ApplicableGameVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.ApplicableGameVersion);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_InternalResourceVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.InternalResourceVersion);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.AssetCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ResourceCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.ResourceCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ResourceGroupCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.ResourceGroupCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UpdatePrefixUri(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.UpdatePrefixUri);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UpdateRetryCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.UpdateRetryCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UpdateWaitingCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.UpdateWaitingCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UpdatingCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.UpdatingCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LoadTotalAgentCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.LoadTotalAgentCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LoadFreeAgentCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.LoadFreeAgentCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LoadWorkingAgentCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.LoadWorkingAgentCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LoadWaitingTaskCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.LoadWaitingTaskCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetAutoReleaseInterval(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.AssetAutoReleaseInterval);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetCapacity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.AssetCapacity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetExpireTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.AssetExpireTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetPriority(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.AssetPriority);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ResourceAutoReleaseInterval(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.ResourceAutoReleaseInterval);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ResourceCapacity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.ResourceCapacity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ResourceExpireTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.ResourceExpireTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ResourcePriority(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.ResourcePriority);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UnloadUnusedAssetsInterval(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.UnloadUnusedAssetsInterval = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UpdatePrefixUri(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.UpdatePrefixUri = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UpdateRetryCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.UpdateRetryCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AssetAutoReleaseInterval(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.AssetAutoReleaseInterval = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AssetCapacity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.AssetCapacity = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AssetExpireTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.AssetExpireTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AssetPriority(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.AssetPriority = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ResourceAutoReleaseInterval(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.ResourceAutoReleaseInterval = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ResourceCapacity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.ResourceCapacity = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ResourceExpireTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.ResourceExpireTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ResourcePriority(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.ResourcePriority = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
