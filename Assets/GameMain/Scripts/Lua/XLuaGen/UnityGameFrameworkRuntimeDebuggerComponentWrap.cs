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
    public class UnityGameFrameworkRuntimeDebuggerComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityGameFramework.Runtime.DebuggerComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 5, 5);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegisterDebuggerWindow", _m_RegisterDebuggerWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDebuggerWindow", _m_GetDebuggerWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectDebuggerWindow", _m_SelectDebuggerWindow);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRecentLogs", _m_GetRecentLogs);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ActiveWindow", _g_get_ActiveWindow);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ShowFullWindow", _g_get_ShowFullWindow);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IconRect", _g_get_IconRect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "WindowRect", _g_get_WindowRect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "WindowScale", _g_get_WindowScale);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "ActiveWindow", _s_set_ActiveWindow);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ShowFullWindow", _s_set_ShowFullWindow);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IconRect", _s_set_IconRect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "WindowRect", _s_set_WindowRect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "WindowScale", _s_set_WindowScale);
            
			
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
					
					UnityGameFramework.Runtime.DebuggerComponent __cl_gen_ret = new UnityGameFramework.Runtime.DebuggerComponent();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.DebuggerComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterDebuggerWindow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.DebuggerComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DebuggerComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string path = LuaAPI.lua_tostring(L, 2);
                    GameFramework.Debugger.IDebuggerWindow debuggerWindow = (GameFramework.Debugger.IDebuggerWindow)translator.GetObject(L, 3, typeof(GameFramework.Debugger.IDebuggerWindow));
                    object[] args = translator.GetParams<object>(L, 4);
                    
                    __cl_gen_to_be_invoked.RegisterDebuggerWindow( path, debuggerWindow, args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDebuggerWindow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.DebuggerComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DebuggerComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string path = LuaAPI.lua_tostring(L, 2);
                    
                        GameFramework.Debugger.IDebuggerWindow __cl_gen_ret = __cl_gen_to_be_invoked.GetDebuggerWindow( path );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectDebuggerWindow(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.DebuggerComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DebuggerComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string path = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.SelectDebuggerWindow( path );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRecentLogs(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.DebuggerComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DebuggerComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<UnityGameFramework.Runtime.DebuggerComponent.LogNode>>(L, 2)) 
                {
                    System.Collections.Generic.List<UnityGameFramework.Runtime.DebuggerComponent.LogNode> results = (System.Collections.Generic.List<UnityGameFramework.Runtime.DebuggerComponent.LogNode>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityGameFramework.Runtime.DebuggerComponent.LogNode>));
                    
                    __cl_gen_to_be_invoked.GetRecentLogs( results );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Collections.Generic.List<UnityGameFramework.Runtime.DebuggerComponent.LogNode>>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.Collections.Generic.List<UnityGameFramework.Runtime.DebuggerComponent.LogNode> results = (System.Collections.Generic.List<UnityGameFramework.Runtime.DebuggerComponent.LogNode>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityGameFramework.Runtime.DebuggerComponent.LogNode>));
                    int count = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.GetRecentLogs( results, count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.DebuggerComponent.GetRecentLogs!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ActiveWindow(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DebuggerComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DebuggerComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.ActiveWindow);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ShowFullWindow(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DebuggerComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DebuggerComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.ShowFullWindow);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IconRect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DebuggerComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DebuggerComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.IconRect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WindowRect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DebuggerComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DebuggerComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.WindowRect);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WindowScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DebuggerComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DebuggerComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.WindowScale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ActiveWindow(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DebuggerComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DebuggerComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.ActiveWindow = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ShowFullWindow(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DebuggerComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DebuggerComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.ShowFullWindow = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IconRect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DebuggerComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DebuggerComponent)translator.FastGetCSObj(L, 1);
                UnityEngine.Rect __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.IconRect = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_WindowRect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DebuggerComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DebuggerComponent)translator.FastGetCSObj(L, 1);
                UnityEngine.Rect __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.WindowRect = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_WindowScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DebuggerComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DebuggerComponent)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.WindowScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
