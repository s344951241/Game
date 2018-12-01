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
    public class GameFrameworkUtilityRandomWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(GameFramework.Utility.Random);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 5, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SetSeed", _m_SetSeed_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRandom", _m_GetRandom_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRandomDouble", _m_GetRandomDouble_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRandomBytes", _m_GetRandomBytes_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "GameFramework.Utility.Random does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetSeed_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int seed = LuaAPI.xlua_tointeger(L, 1);
                    
                    GameFramework.Utility.Random.SetSeed( seed );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRandom_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 0) 
                {
                    
                        int __cl_gen_ret = GameFramework.Utility.Random.GetRandom(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int maxValue = LuaAPI.xlua_tointeger(L, 1);
                    
                        int __cl_gen_ret = GameFramework.Utility.Random.GetRandom( maxValue );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int minValue = LuaAPI.xlua_tointeger(L, 1);
                    int maxValue = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = GameFramework.Utility.Random.GetRandom( minValue, maxValue );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameFramework.Utility.Random.GetRandom!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRandomDouble_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        double __cl_gen_ret = GameFramework.Utility.Random.GetRandomDouble(  );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRandomBytes_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] buffer = LuaAPI.lua_tobytes(L, 1);
                    
                    GameFramework.Utility.Random.GetRandomBytes( buffer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
