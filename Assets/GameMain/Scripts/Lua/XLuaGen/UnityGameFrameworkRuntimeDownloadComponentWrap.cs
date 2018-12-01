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
    public class UnityGameFrameworkRuntimeDownloadComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityGameFramework.Runtime.DownloadComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 7, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddDownload", _m_AddDownload);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveDownload", _m_RemoveDownload);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveAllDownload", _m_RemoveAllDownload);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "TotalAgentCount", _g_get_TotalAgentCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "FreeAgentCount", _g_get_FreeAgentCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "WorkingAgentCount", _g_get_WorkingAgentCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "WaitingTaskCount", _g_get_WaitingTaskCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Timeout", _g_get_Timeout);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "FlushSize", _g_get_FlushSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CurrentSpeed", _g_get_CurrentSpeed);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Timeout", _s_set_Timeout);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "FlushSize", _s_set_FlushSize);
            
			
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
					
					UnityGameFramework.Runtime.DownloadComponent __cl_gen_ret = new UnityGameFramework.Runtime.DownloadComponent();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.DownloadComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddDownload(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.DownloadComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DownloadComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    string downloadPath = LuaAPI.lua_tostring(L, 2);
                    string downloadUri = LuaAPI.lua_tostring(L, 3);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.AddDownload( downloadPath, downloadUri );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string downloadPath = LuaAPI.lua_tostring(L, 2);
                    string downloadUri = LuaAPI.lua_tostring(L, 3);
                    int priority = LuaAPI.xlua_tointeger(L, 4);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.AddDownload( downloadPath, downloadUri, priority );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 4)) 
                {
                    string downloadPath = LuaAPI.lua_tostring(L, 2);
                    string downloadUri = LuaAPI.lua_tostring(L, 3);
                    object userData = translator.GetObject(L, 4, typeof(object));
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.AddDownload( downloadPath, downloadUri, userData );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    string downloadPath = LuaAPI.lua_tostring(L, 2);
                    string downloadUri = LuaAPI.lua_tostring(L, 3);
                    int priority = LuaAPI.xlua_tointeger(L, 4);
                    object userData = translator.GetObject(L, 5, typeof(object));
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.AddDownload( downloadPath, downloadUri, priority, userData );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.DownloadComponent.AddDownload!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveDownload(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.DownloadComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DownloadComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int serialId = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.RemoveDownload( serialId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveAllDownload(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.DownloadComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DownloadComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.RemoveAllDownload(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TotalAgentCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DownloadComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DownloadComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.TotalAgentCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_FreeAgentCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DownloadComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DownloadComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.FreeAgentCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WorkingAgentCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DownloadComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DownloadComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.WorkingAgentCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WaitingTaskCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DownloadComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DownloadComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.WaitingTaskCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Timeout(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DownloadComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DownloadComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.Timeout);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_FlushSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DownloadComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DownloadComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.FlushSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CurrentSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DownloadComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DownloadComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.CurrentSpeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Timeout(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DownloadComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DownloadComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.Timeout = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_FlushSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DownloadComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DownloadComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.FlushSize = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
