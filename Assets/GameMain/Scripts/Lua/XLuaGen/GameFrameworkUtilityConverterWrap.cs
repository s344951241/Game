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
    public class GameFrameworkUtilityConverterWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(GameFramework.Utility.Converter);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 17, 2, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCentimetersFromPixels", _m_GetCentimetersFromPixels_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetPixelsFromCentimeters", _m_GetPixelsFromCentimeters_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetInchesFromPixels", _m_GetInchesFromPixels_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetPixelsFromInches", _m_GetPixelsFromInches_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetBytes", _m_GetBytes_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetBoolean", _m_GetBoolean_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetChar", _m_GetChar_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetInt16", _m_GetInt16_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetUInt16", _m_GetUInt16_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetInt32", _m_GetInt32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetUInt32", _m_GetUInt32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetInt64", _m_GetInt64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetUInt64", _m_GetUInt64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSingle", _m_GetSingle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDouble", _m_GetDouble_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetString", _m_GetString_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "IsLittleEndian", _g_get_IsLittleEndian);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ScreenDpi", _g_get_ScreenDpi);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ScreenDpi", _s_set_ScreenDpi);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "GameFramework.Utility.Converter does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCentimetersFromPixels_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float pixels = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        float __cl_gen_ret = GameFramework.Utility.Converter.GetCentimetersFromPixels( pixels );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixelsFromCentimeters_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float centimeters = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        float __cl_gen_ret = GameFramework.Utility.Converter.GetPixelsFromCentimeters( centimeters );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInchesFromPixels_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float pixels = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        float __cl_gen_ret = GameFramework.Utility.Converter.GetInchesFromPixels( pixels );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixelsFromInches_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float inches = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        float __cl_gen_ret = GameFramework.Utility.Converter.GetPixelsFromInches( inches );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBytes_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)) 
                {
                    bool value = LuaAPI.lua_toboolean(L, 1);
                    
                        byte[] __cl_gen_ret = GameFramework.Utility.Converter.GetBytes( value );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    char value = (char)LuaAPI.xlua_tointeger(L, 1);
                    
                        byte[] __cl_gen_ret = GameFramework.Utility.Converter.GetBytes( value );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    short value = (short)LuaAPI.xlua_tointeger(L, 1);
                    
                        byte[] __cl_gen_ret = GameFramework.Utility.Converter.GetBytes( value );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    ushort value = (ushort)LuaAPI.xlua_tointeger(L, 1);
                    
                        byte[] __cl_gen_ret = GameFramework.Utility.Converter.GetBytes( value );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int value = LuaAPI.xlua_tointeger(L, 1);
                    
                        byte[] __cl_gen_ret = GameFramework.Utility.Converter.GetBytes( value );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    uint value = LuaAPI.xlua_touint(L, 1);
                    
                        byte[] __cl_gen_ret = GameFramework.Utility.Converter.GetBytes( value );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))) 
                {
                    long value = LuaAPI.lua_toint64(L, 1);
                    
                        byte[] __cl_gen_ret = GameFramework.Utility.Converter.GetBytes( value );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isuint64(L, 1))) 
                {
                    ulong value = LuaAPI.lua_touint64(L, 1);
                    
                        byte[] __cl_gen_ret = GameFramework.Utility.Converter.GetBytes( value );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    float value = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        byte[] __cl_gen_ret = GameFramework.Utility.Converter.GetBytes( value );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    double value = LuaAPI.lua_tonumber(L, 1);
                    
                        byte[] __cl_gen_ret = GameFramework.Utility.Converter.GetBytes( value );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string value = LuaAPI.lua_tostring(L, 1);
                    
                        byte[] __cl_gen_ret = GameFramework.Utility.Converter.GetBytes( value );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameFramework.Utility.Converter.GetBytes!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBoolean_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    
                        bool __cl_gen_ret = GameFramework.Utility.Converter.GetBoolean( value );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    int startIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = GameFramework.Utility.Converter.GetBoolean( value, startIndex );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameFramework.Utility.Converter.GetBoolean!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetChar_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    
                        char __cl_gen_ret = GameFramework.Utility.Converter.GetChar( value );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    int startIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        char __cl_gen_ret = GameFramework.Utility.Converter.GetChar( value, startIndex );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameFramework.Utility.Converter.GetChar!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInt16_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    
                        short __cl_gen_ret = GameFramework.Utility.Converter.GetInt16( value );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    int startIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        short __cl_gen_ret = GameFramework.Utility.Converter.GetInt16( value, startIndex );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameFramework.Utility.Converter.GetInt16!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUInt16_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    
                        ushort __cl_gen_ret = GameFramework.Utility.Converter.GetUInt16( value );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    int startIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        ushort __cl_gen_ret = GameFramework.Utility.Converter.GetUInt16( value, startIndex );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameFramework.Utility.Converter.GetUInt16!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInt32_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    
                        int __cl_gen_ret = GameFramework.Utility.Converter.GetInt32( value );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    int startIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = GameFramework.Utility.Converter.GetInt32( value, startIndex );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameFramework.Utility.Converter.GetInt32!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUInt32_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    
                        uint __cl_gen_ret = GameFramework.Utility.Converter.GetUInt32( value );
                        LuaAPI.xlua_pushuint(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    int startIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        uint __cl_gen_ret = GameFramework.Utility.Converter.GetUInt32( value, startIndex );
                        LuaAPI.xlua_pushuint(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameFramework.Utility.Converter.GetUInt32!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInt64_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    
                        long __cl_gen_ret = GameFramework.Utility.Converter.GetInt64( value );
                        LuaAPI.lua_pushint64(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    int startIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        long __cl_gen_ret = GameFramework.Utility.Converter.GetInt64( value, startIndex );
                        LuaAPI.lua_pushint64(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameFramework.Utility.Converter.GetInt64!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUInt64_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    
                        ulong __cl_gen_ret = GameFramework.Utility.Converter.GetUInt64( value );
                        LuaAPI.lua_pushuint64(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    int startIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        ulong __cl_gen_ret = GameFramework.Utility.Converter.GetUInt64( value, startIndex );
                        LuaAPI.lua_pushuint64(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameFramework.Utility.Converter.GetUInt64!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSingle_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    
                        float __cl_gen_ret = GameFramework.Utility.Converter.GetSingle( value );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    int startIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        float __cl_gen_ret = GameFramework.Utility.Converter.GetSingle( value, startIndex );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameFramework.Utility.Converter.GetSingle!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDouble_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    
                        double __cl_gen_ret = GameFramework.Utility.Converter.GetDouble( value );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    int startIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        double __cl_gen_ret = GameFramework.Utility.Converter.GetDouble( value, startIndex );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameFramework.Utility.Converter.GetDouble!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetString_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] value = LuaAPI.lua_tobytes(L, 1);
                    
                        string __cl_gen_ret = GameFramework.Utility.Converter.GetString( value );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsLittleEndian(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, GameFramework.Utility.Converter.IsLittleEndian);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ScreenDpi(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, GameFramework.Utility.Converter.ScreenDpi);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ScreenDpi(RealStatePtr L)
        {
		    try {
                
			    GameFramework.Utility.Converter.ScreenDpi = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
