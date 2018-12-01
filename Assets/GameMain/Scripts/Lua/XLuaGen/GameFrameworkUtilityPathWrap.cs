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
    public class GameFrameworkUtilityPathWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(GameFramework.Utility.Path);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 7, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRegularPath", _m_GetRegularPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCombinePath", _m_GetCombinePath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRemotePath", _m_GetRemotePath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetResourceNameWithSuffix", _m_GetResourceNameWithSuffix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetResourceNameWithCrc32AndSuffix", _m_GetResourceNameWithCrc32AndSuffix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RemoveEmptyDirectory", _m_RemoveEmptyDirectory_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "GameFramework.Utility.Path does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRegularPath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string path = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = GameFramework.Utility.Path.GetRegularPath( path );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCombinePath_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string[] path = translator.GetParams<string>(L, 1);
                    
                        string __cl_gen_ret = GameFramework.Utility.Path.GetCombinePath( path );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRemotePath_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string[] path = translator.GetParams<string>(L, 1);
                    
                        string __cl_gen_ret = GameFramework.Utility.Path.GetRemotePath( path );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetResourceNameWithSuffix_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string resourceName = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = GameFramework.Utility.Path.GetResourceNameWithSuffix( resourceName );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetResourceNameWithCrc32AndSuffix_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string resourceName = LuaAPI.lua_tostring(L, 1);
                    int hashCode = LuaAPI.xlua_tointeger(L, 2);
                    
                        string __cl_gen_ret = GameFramework.Utility.Path.GetResourceNameWithCrc32AndSuffix( resourceName, hashCode );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveEmptyDirectory_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string directoryName = LuaAPI.lua_tostring(L, 1);
                    
                        bool __cl_gen_ret = GameFramework.Utility.Path.RemoveEmptyDirectory( directoryName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
