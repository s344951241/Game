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
    public class UnityGameFrameworkRuntimeConfigComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityGameFramework.Runtime.ConfigComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 9, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadConfig", _m_LoadConfig);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ParseConfig", _m_ParseConfig);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasConfig", _m_HasConfig);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveConfig", _m_RemoveConfig);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveAllConfigs", _m_RemoveAllConfigs);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBool", _m_GetBool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInt", _m_GetInt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetFloat", _m_GetFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetString", _m_GetString);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ConfigCount", _g_get_ConfigCount);
            
			
			
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
					
					UnityGameFramework.Runtime.ConfigComponent __cl_gen_ret = new UnityGameFramework.Runtime.ConfigComponent();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ConfigComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadConfig(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ConfigComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ConfigComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    string configName = LuaAPI.lua_tostring(L, 2);
                    string configAssetName = LuaAPI.lua_tostring(L, 3);
                    
                    __cl_gen_to_be_invoked.LoadConfig( configName, configAssetName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string configName = LuaAPI.lua_tostring(L, 2);
                    string configAssetName = LuaAPI.lua_tostring(L, 3);
                    int priority = LuaAPI.xlua_tointeger(L, 4);
                    
                    __cl_gen_to_be_invoked.LoadConfig( configName, configAssetName, priority );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 4)) 
                {
                    string configName = LuaAPI.lua_tostring(L, 2);
                    string configAssetName = LuaAPI.lua_tostring(L, 3);
                    object userData = translator.GetObject(L, 4, typeof(object));
                    
                    __cl_gen_to_be_invoked.LoadConfig( configName, configAssetName, userData );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    string configName = LuaAPI.lua_tostring(L, 2);
                    string configAssetName = LuaAPI.lua_tostring(L, 3);
                    int priority = LuaAPI.xlua_tointeger(L, 4);
                    object userData = translator.GetObject(L, 5, typeof(object));
                    
                    __cl_gen_to_be_invoked.LoadConfig( configName, configAssetName, priority, userData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ConfigComponent.LoadConfig!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ParseConfig(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ConfigComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ConfigComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string text = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.ParseConfig( text );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string text = LuaAPI.lua_tostring(L, 2);
                    object userData = translator.GetObject(L, 3, typeof(object));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.ParseConfig( text, userData );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ConfigComponent.ParseConfig!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasConfig(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ConfigComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ConfigComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string configName = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.HasConfig( configName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveConfig(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ConfigComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ConfigComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string configName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.RemoveConfig( configName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveAllConfigs(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ConfigComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ConfigComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.RemoveAllConfigs(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ConfigComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ConfigComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string configName = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.GetBool( configName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string configName = LuaAPI.lua_tostring(L, 2);
                    bool defaultValue = LuaAPI.lua_toboolean(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.GetBool( configName, defaultValue );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ConfigComponent.GetBool!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ConfigComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ConfigComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string configName = LuaAPI.lua_tostring(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetInt( configName );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string configName = LuaAPI.lua_tostring(L, 2);
                    int defaultValue = LuaAPI.xlua_tointeger(L, 3);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetInt( configName, defaultValue );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ConfigComponent.GetInt!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFloat(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ConfigComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ConfigComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string configName = LuaAPI.lua_tostring(L, 2);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.GetFloat( configName );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string configName = LuaAPI.lua_tostring(L, 2);
                    float defaultValue = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.GetFloat( configName, defaultValue );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ConfigComponent.GetFloat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ConfigComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ConfigComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string configName = LuaAPI.lua_tostring(L, 2);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.GetString( configName );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    string configName = LuaAPI.lua_tostring(L, 2);
                    string defaultValue = LuaAPI.lua_tostring(L, 3);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.GetString( configName, defaultValue );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ConfigComponent.GetString!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ConfigCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ConfigComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ConfigComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.ConfigCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
