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
    public class GameFrameworkUtilityTextWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(GameFramework.Utility.Text);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 5, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Format", _m_Format_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SplitToLines", _m_SplitToLines_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFullName", _m_GetFullName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FieldNameForDisplay", _m_FieldNameForDisplay_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "GameFramework.Utility.Text does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Format_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 2)) 
                {
                    string format = LuaAPI.lua_tostring(L, 1);
                    object arg0 = translator.GetObject(L, 2, typeof(object));
                    
                        string __cl_gen_ret = GameFramework.Utility.Text.Format( format, arg0 );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<object>(L, 2))) 
                {
                    string format = LuaAPI.lua_tostring(L, 1);
                    object[] args = translator.GetParams<object>(L, 2);
                    
                        string __cl_gen_ret = GameFramework.Utility.Text.Format( format, args );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    string format = LuaAPI.lua_tostring(L, 1);
                    object arg0 = translator.GetObject(L, 2, typeof(object));
                    object arg1 = translator.GetObject(L, 3, typeof(object));
                    
                        string __cl_gen_ret = GameFramework.Utility.Text.Format( format, arg0, arg1 );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 2)&& translator.Assignable<object>(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    string format = LuaAPI.lua_tostring(L, 1);
                    object arg0 = translator.GetObject(L, 2, typeof(object));
                    object arg1 = translator.GetObject(L, 3, typeof(object));
                    object arg2 = translator.GetObject(L, 4, typeof(object));
                    
                        string __cl_gen_ret = GameFramework.Utility.Text.Format( format, arg0, arg1, arg2 );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameFramework.Utility.Text.Format!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SplitToLines_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string text = LuaAPI.lua_tostring(L, 1);
                    
                        string[] __cl_gen_ret = GameFramework.Utility.Text.SplitToLines( text );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFullName_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        string __cl_gen_ret = GameFramework.Utility.Text.GetFullName( type, name );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FieldNameForDisplay_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string fieldName = LuaAPI.lua_tostring(L, 1);
                    
                        string __cl_gen_ret = GameFramework.Utility.Text.FieldNameForDisplay( fieldName );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
