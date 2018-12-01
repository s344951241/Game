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
    public class UnityGameFrameworkRuntimePlaySoundDependencyAssetEventArgsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 10, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Fill", _m_Fill);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Id", _g_get_Id);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SerialId", _g_get_SerialId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SoundAssetName", _g_get_SoundAssetName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SoundGroupName", _g_get_SoundGroupName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "PlaySoundParams", _g_get_PlaySoundParams);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DependencyAssetName", _g_get_DependencyAssetName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LoadedCount", _g_get_LoadedCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "TotalCount", _g_get_TotalCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "BindingEntity", _g_get_BindingEntity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UserData", _g_get_UserData);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EventId", UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs.EventId);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs __cl_gen_ret = new UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Fill(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    GameFramework.Sound.PlaySoundDependencyAssetEventArgs e = (GameFramework.Sound.PlaySoundDependencyAssetEventArgs)translator.GetObject(L, 2, typeof(GameFramework.Sound.PlaySoundDependencyAssetEventArgs));
                    
                        UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs __cl_gen_ret = __cl_gen_to_be_invoked.Fill( e );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Id(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.Id);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SerialId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.SerialId);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SoundAssetName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.SoundAssetName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SoundGroupName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.SoundGroupName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PlaySoundParams(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.PlaySoundParams);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DependencyAssetName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.DependencyAssetName);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LoadedCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.LoadedCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TotalCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.TotalCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BindingEntity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.BindingEntity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UserData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.PlaySoundDependencyAssetEventArgs)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, __cl_gen_to_be_invoked.UserData);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
