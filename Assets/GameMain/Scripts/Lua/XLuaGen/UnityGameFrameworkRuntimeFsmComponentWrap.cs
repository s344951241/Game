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
    public class UnityGameFrameworkRuntimeFsmComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityGameFramework.Runtime.FsmComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasFsm", _m_HasFsm);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetFsm", _m_GetFsm);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllFsms", _m_GetAllFsms);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DestroyFsm", _m_DestroyFsm);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Count", _g_get_Count);
            
			
			
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
					
					UnityGameFramework.Runtime.FsmComponent __cl_gen_ret = new UnityGameFramework.Runtime.FsmComponent();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.FsmComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasFsm(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.FsmComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.FsmComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type ownerType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.HasFsm( ownerType );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    System.Type ownerType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.HasFsm( ownerType, name );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.FsmComponent.HasFsm!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFsm(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.FsmComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.FsmComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type ownerType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        GameFramework.Fsm.FsmBase __cl_gen_ret = __cl_gen_to_be_invoked.GetFsm( ownerType );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    System.Type ownerType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    
                        GameFramework.Fsm.FsmBase __cl_gen_ret = __cl_gen_to_be_invoked.GetFsm( ownerType, name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.FsmComponent.GetFsm!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllFsms(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.FsmComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.FsmComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                        GameFramework.Fsm.FsmBase[] __cl_gen_ret = __cl_gen_to_be_invoked.GetAllFsms(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<GameFramework.Fsm.FsmBase>>(L, 2)) 
                {
                    System.Collections.Generic.List<GameFramework.Fsm.FsmBase> results = (System.Collections.Generic.List<GameFramework.Fsm.FsmBase>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<GameFramework.Fsm.FsmBase>));
                    
                    __cl_gen_to_be_invoked.GetAllFsms( results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.FsmComponent.GetAllFsms!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DestroyFsm(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.FsmComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.FsmComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type ownerType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.DestroyFsm( ownerType );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<GameFramework.Fsm.FsmBase>(L, 2)) 
                {
                    GameFramework.Fsm.FsmBase fsm = (GameFramework.Fsm.FsmBase)translator.GetObject(L, 2, typeof(GameFramework.Fsm.FsmBase));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.DestroyFsm( fsm );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    System.Type ownerType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.DestroyFsm( ownerType, name );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.FsmComponent.DestroyFsm!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Count(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.FsmComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.FsmComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.Count);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
