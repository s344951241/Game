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
    public class UnityGameFrameworkRuntimeResourceUpdateChangedEventArgsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 6, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Fill", _m_Fill);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Id", _g_get_Id);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Name", _g_get_Name);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DownloadPath", _g_get_DownloadPath);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DownloadUri", _g_get_DownloadUri);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CurrentLength", _g_get_CurrentLength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ZipLength", _g_get_ZipLength);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EventId", UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs.EventId);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs __cl_gen_ret = new UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    GameFramework.Resource.ResourceUpdateChangedEventArgs e = (GameFramework.Resource.ResourceUpdateChangedEventArgs)translator.GetObject(L, 2, typeof(GameFramework.Resource.ResourceUpdateChangedEventArgs));
                    
                        UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs __cl_gen_ret = __cl_gen_to_be_invoked.Fill( e );
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
			
                UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.Id);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.Name);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DownloadPath(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.DownloadPath);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DownloadUri(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.DownloadUri);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CurrentLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.CurrentLength);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ZipLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ResourceUpdateChangedEventArgs)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.ZipLength);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
