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
    public class UnityGameFrameworkRuntimeBaseComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityGameFramework.Runtime.BaseComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 9, 7);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PauseGame", _m_PauseGame);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResumeGame", _m_ResumeGame);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetNormalGameSpeed", _m_ResetNormalGameSpeed);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "EditorResourceMode", _g_get_EditorResourceMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "EditorLanguage", _g_get_EditorLanguage);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "EditorResourceHelper", _g_get_EditorResourceHelper);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "FrameRate", _g_get_FrameRate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "GameSpeed", _g_get_GameSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsGamePaused", _g_get_IsGamePaused);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsNormalGameSpeed", _g_get_IsNormalGameSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RunInBackground", _g_get_RunInBackground);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "NeverSleep", _g_get_NeverSleep);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "EditorResourceMode", _s_set_EditorResourceMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "EditorLanguage", _s_set_EditorLanguage);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "EditorResourceHelper", _s_set_EditorResourceHelper);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "FrameRate", _s_set_FrameRate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "GameSpeed", _s_set_GameSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "RunInBackground", _s_set_RunInBackground);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "NeverSleep", _s_set_NeverSleep);
            
			
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
					
					UnityGameFramework.Runtime.BaseComponent __cl_gen_ret = new UnityGameFramework.Runtime.BaseComponent();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.BaseComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PauseGame(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.PauseGame(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResumeGame(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.ResumeGame(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetNormalGameSpeed(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.ResetNormalGameSpeed(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EditorResourceMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.EditorResourceMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EditorLanguage(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.EditorLanguage);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EditorResourceHelper(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, __cl_gen_to_be_invoked.EditorResourceHelper);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_FrameRate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.FrameRate);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GameSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.GameSpeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsGamePaused(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.IsGamePaused);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsNormalGameSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.IsNormalGameSpeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RunInBackground(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.RunInBackground);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_NeverSleep(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.NeverSleep);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_EditorResourceMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.EditorResourceMode = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_EditorLanguage(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
                GameFramework.Localization.Language __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.EditorLanguage = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_EditorResourceHelper(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.EditorResourceHelper = (GameFramework.Resource.IResourceManager)translator.GetObject(L, 2, typeof(GameFramework.Resource.IResourceManager));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_FrameRate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.FrameRate = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_GameSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.GameSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RunInBackground(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.RunInBackground = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_NeverSleep(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.BaseComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.BaseComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.NeverSleep = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
