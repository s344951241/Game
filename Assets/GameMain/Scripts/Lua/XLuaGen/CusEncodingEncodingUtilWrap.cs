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
    public class CusEncodingEncodingUtilWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(CusEncoding.EncodingUtil);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 8, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "FileByteToLocal", _m_FileByteToLocal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ByteToLocal", _m_ByteToLocal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ByteConvertCharArrayByNet", _m_ByteConvertCharArrayByNet_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GbkConvertToString", _m_GbkConvertToString_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GbkConvertToChar", _m_GbkConvertToChar_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CharArrayConvertByteByNet", _m_CharArrayConvertByteByNet_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGBKLength", _m_GetGBKLength_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					CusEncoding.EncodingUtil __cl_gen_ret = new CusEncoding.EncodingUtil();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to CusEncoding.EncodingUtil constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FileByteToLocal_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] byteData = LuaAPI.lua_tobytes(L, 1);
                    
                        byte[] __cl_gen_ret = CusEncoding.EncodingUtil.FileByteToLocal( byteData );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ByteToLocal_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] byteData = LuaAPI.lua_tobytes(L, 1);
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    int len = LuaAPI.xlua_tointeger(L, 3);
                    
                        byte[] __cl_gen_ret = CusEncoding.EncodingUtil.ByteToLocal( byteData, index, len );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ByteConvertCharArrayByNet_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    byte[] byteArray = LuaAPI.lua_tobytes(L, 1);
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    int length = LuaAPI.xlua_tointeger(L, 3);
                    
                        char[] __cl_gen_ret = CusEncoding.EncodingUtil.ByteConvertCharArrayByNet( byteArray, index, length );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GbkConvertToString_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] byteArray = LuaAPI.lua_tobytes(L, 1);
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    int length = LuaAPI.xlua_tointeger(L, 3);
                    
                        string __cl_gen_ret = CusEncoding.EncodingUtil.GbkConvertToString( byteArray, index, length );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GbkConvertToChar_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    char[] chars;
                    int charCount;
                    byte[] byteArray = LuaAPI.lua_tobytes(L, 1);
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    int length = LuaAPI.xlua_tointeger(L, 3);
                    
                    CusEncoding.EncodingUtil.GbkConvertToChar( out chars, out charCount, byteArray, index, length );
                    translator.Push(L, chars);
                        
                    LuaAPI.xlua_pushinteger(L, charCount);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CharArrayConvertByteByNet_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    char[] charArray = (char[])translator.GetObject(L, 1, typeof(char[]));
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    int length = LuaAPI.xlua_tointeger(L, 3);
                    
                        byte[] __cl_gen_ret = CusEncoding.EncodingUtil.CharArrayConvertByteByNet( charArray, index, length );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGBKLength_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    char[] charArray = (char[])translator.GetObject(L, 1, typeof(char[]));
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    int length = LuaAPI.xlua_tointeger(L, 3);
                    
                        int __cl_gen_ret = CusEncoding.EncodingUtil.GetGBKLength( charArray, index, length );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
