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
    public class GameProcedureLuaWorkerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Game.ProcedureLuaWorker);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Cleanup", _m_Cleanup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "NotifyScript", _m_NotifyScript);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDestroy", _m_OnDestroy);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnEnter", _m_OnEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnLeave", _m_OnLeave);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnUpdate", _m_OnUpdate);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Script", _g_get_Script);
            
			
			
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
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<Game.ProcedureBase>(L, 2) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))
				{
					Game.ProcedureBase target = (Game.ProcedureBase)translator.GetObject(L, 2, typeof(Game.ProcedureBase));
					string scriptName = LuaAPI.lua_tostring(L, 3);
					
					Game.ProcedureLuaWorker __cl_gen_ret = new Game.ProcedureLuaWorker(target, scriptName);
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Game.ProcedureLuaWorker constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Cleanup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Game.ProcedureLuaWorker __cl_gen_to_be_invoked = (Game.ProcedureLuaWorker)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Cleanup(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NotifyScript(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Game.ProcedureLuaWorker __cl_gen_to_be_invoked = (Game.ProcedureLuaWorker)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& translator.Assignable<object>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    object param0 = translator.GetObject(L, 2, typeof(object));
                    object param1 = translator.GetObject(L, 3, typeof(object));
                    
                    __cl_gen_to_be_invoked.NotifyScript( param0, param1 );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object param0 = translator.GetObject(L, 2, typeof(object));
                    
                    __cl_gen_to_be_invoked.NotifyScript( param0 );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Game.ProcedureLuaWorker.NotifyScript!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnDestroy(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Game.ProcedureLuaWorker __cl_gen_to_be_invoked = (Game.ProcedureLuaWorker)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager> procedureOwner = (GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>)translator.GetObject(L, 2, typeof(GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>));
                    
                    __cl_gen_to_be_invoked.OnDestroy( procedureOwner );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnEnter(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Game.ProcedureLuaWorker __cl_gen_to_be_invoked = (Game.ProcedureLuaWorker)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager> procedureOwner = (GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>)translator.GetObject(L, 2, typeof(GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>));
                    
                    __cl_gen_to_be_invoked.OnEnter( procedureOwner );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnLeave(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Game.ProcedureLuaWorker __cl_gen_to_be_invoked = (Game.ProcedureLuaWorker)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager> procedureOwner = (GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>)translator.GetObject(L, 2, typeof(GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>));
                    bool isShutdown = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.OnLeave( procedureOwner, isShutdown );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnUpdate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Game.ProcedureLuaWorker __cl_gen_to_be_invoked = (Game.ProcedureLuaWorker)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager> procedureOwner = (GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>)translator.GetObject(L, 2, typeof(GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>));
                    float elapseSeconds = (float)LuaAPI.lua_tonumber(L, 3);
                    float realElapseSeconds = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    __cl_gen_to_be_invoked.OnUpdate( procedureOwner, elapseSeconds, realElapseSeconds );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Script(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Game.ProcedureLuaWorker __cl_gen_to_be_invoked = (Game.ProcedureLuaWorker)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.Script);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
