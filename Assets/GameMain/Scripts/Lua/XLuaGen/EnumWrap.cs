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
    
    public class CusEncodingEncodingTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(CusEncoding.EncodingType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(CusEncoding.EncodingType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(CusEncoding.EncodingType), L, null, 9, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Encoding_INVALID", CusEncoding.EncodingType.Encoding_INVALID);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Encoding_ASCII", CusEncoding.EncodingType.Encoding_ASCII);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Encoding_UTF8_BOM", CusEncoding.EncodingType.Encoding_UTF8_BOM);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Encoding_UTF8", CusEncoding.EncodingType.Encoding_UTF8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Encoding_Unicode", CusEncoding.EncodingType.Encoding_Unicode);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Encoding_BigEndianUnicode", CusEncoding.EncodingType.Encoding_BigEndianUnicode);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Encoding_GBK", CusEncoding.EncodingType.Encoding_GBK);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Encoding_Unrecognized", CusEncoding.EncodingType.Encoding_Unrecognized);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(CusEncoding.EncodingType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushCusEncodingEncodingType(L, (CusEncoding.EncodingType)LuaAPI.xlua_tointeger(L, 1));
            }
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Encoding_INVALID"))
                {
                    translator.PushCusEncodingEncodingType(L, CusEncoding.EncodingType.Encoding_INVALID);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Encoding_ASCII"))
                {
                    translator.PushCusEncodingEncodingType(L, CusEncoding.EncodingType.Encoding_ASCII);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Encoding_UTF8_BOM"))
                {
                    translator.PushCusEncodingEncodingType(L, CusEncoding.EncodingType.Encoding_UTF8_BOM);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Encoding_UTF8"))
                {
                    translator.PushCusEncodingEncodingType(L, CusEncoding.EncodingType.Encoding_UTF8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Encoding_Unicode"))
                {
                    translator.PushCusEncodingEncodingType(L, CusEncoding.EncodingType.Encoding_Unicode);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Encoding_BigEndianUnicode"))
                {
                    translator.PushCusEncodingEncodingType(L, CusEncoding.EncodingType.Encoding_BigEndianUnicode);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Encoding_GBK"))
                {
                    translator.PushCusEncodingEncodingType(L, CusEncoding.EncodingType.Encoding_GBK);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Encoding_Unrecognized"))
                {
                    translator.PushCusEncodingEncodingType(L, CusEncoding.EncodingType.Encoding_Unrecognized);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for CusEncoding.EncodingType!");
                }
            }
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for CusEncoding.EncodingType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
}