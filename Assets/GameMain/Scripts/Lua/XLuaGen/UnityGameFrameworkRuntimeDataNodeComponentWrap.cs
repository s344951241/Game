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
    public class UnityGameFrameworkRuntimeDataNodeComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityGameFramework.Runtime.DataNodeComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetData", _m_GetData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetData", _m_SetData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetNode", _m_GetNode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetOrAddNode", _m_GetOrAddNode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveNode", _m_RemoveNode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Root", _g_get_Root);
            
			
			
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
					
					UnityGameFramework.Runtime.DataNodeComponent __cl_gen_ret = new UnityGameFramework.Runtime.DataNodeComponent();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.DataNodeComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.DataNodeComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DataNodeComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string path = LuaAPI.lua_tostring(L, 2);
                    
                        GameFramework.Variable __cl_gen_ret = __cl_gen_to_be_invoked.GetData( path );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<GameFramework.DataNode.IDataNode>(L, 3)) 
                {
                    string path = LuaAPI.lua_tostring(L, 2);
                    GameFramework.DataNode.IDataNode node = (GameFramework.DataNode.IDataNode)translator.GetObject(L, 3, typeof(GameFramework.DataNode.IDataNode));
                    
                        GameFramework.Variable __cl_gen_ret = __cl_gen_to_be_invoked.GetData( path, node );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.DataNodeComponent.GetData!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.DataNodeComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DataNodeComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<GameFramework.Variable>(L, 3)) 
                {
                    string path = LuaAPI.lua_tostring(L, 2);
                    GameFramework.Variable data = (GameFramework.Variable)translator.GetObject(L, 3, typeof(GameFramework.Variable));
                    
                    __cl_gen_to_be_invoked.SetData( path, data );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<GameFramework.Variable>(L, 3)) 
                {
                    string path = LuaAPI.lua_tostring(L, 2);
                    GameFramework.Variable data = (GameFramework.Variable)translator.GetObject(L, 3, typeof(GameFramework.Variable));
                    
                    __cl_gen_to_be_invoked.SetData( path, data );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<GameFramework.Variable>(L, 3)&& translator.Assignable<GameFramework.DataNode.IDataNode>(L, 4)) 
                {
                    string path = LuaAPI.lua_tostring(L, 2);
                    GameFramework.Variable data = (GameFramework.Variable)translator.GetObject(L, 3, typeof(GameFramework.Variable));
                    GameFramework.DataNode.IDataNode node = (GameFramework.DataNode.IDataNode)translator.GetObject(L, 4, typeof(GameFramework.DataNode.IDataNode));
                    
                    __cl_gen_to_be_invoked.SetData( path, data, node );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<GameFramework.Variable>(L, 3)&& translator.Assignable<GameFramework.DataNode.IDataNode>(L, 4)) 
                {
                    string path = LuaAPI.lua_tostring(L, 2);
                    GameFramework.Variable data = (GameFramework.Variable)translator.GetObject(L, 3, typeof(GameFramework.Variable));
                    GameFramework.DataNode.IDataNode node = (GameFramework.DataNode.IDataNode)translator.GetObject(L, 4, typeof(GameFramework.DataNode.IDataNode));
                    
                    __cl_gen_to_be_invoked.SetData( path, data, node );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.DataNodeComponent.SetData!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.DataNodeComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DataNodeComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string path = LuaAPI.lua_tostring(L, 2);
                    
                        GameFramework.DataNode.IDataNode __cl_gen_ret = __cl_gen_to_be_invoked.GetNode( path );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<GameFramework.DataNode.IDataNode>(L, 3)) 
                {
                    string path = LuaAPI.lua_tostring(L, 2);
                    GameFramework.DataNode.IDataNode node = (GameFramework.DataNode.IDataNode)translator.GetObject(L, 3, typeof(GameFramework.DataNode.IDataNode));
                    
                        GameFramework.DataNode.IDataNode __cl_gen_ret = __cl_gen_to_be_invoked.GetNode( path, node );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.DataNodeComponent.GetNode!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetOrAddNode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.DataNodeComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DataNodeComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string path = LuaAPI.lua_tostring(L, 2);
                    
                        GameFramework.DataNode.IDataNode __cl_gen_ret = __cl_gen_to_be_invoked.GetOrAddNode( path );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<GameFramework.DataNode.IDataNode>(L, 3)) 
                {
                    string path = LuaAPI.lua_tostring(L, 2);
                    GameFramework.DataNode.IDataNode node = (GameFramework.DataNode.IDataNode)translator.GetObject(L, 3, typeof(GameFramework.DataNode.IDataNode));
                    
                        GameFramework.DataNode.IDataNode __cl_gen_ret = __cl_gen_to_be_invoked.GetOrAddNode( path, node );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.DataNodeComponent.GetOrAddNode!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveNode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.DataNodeComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DataNodeComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string path = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.RemoveNode( path );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<GameFramework.DataNode.IDataNode>(L, 3)) 
                {
                    string path = LuaAPI.lua_tostring(L, 2);
                    GameFramework.DataNode.IDataNode node = (GameFramework.DataNode.IDataNode)translator.GetObject(L, 3, typeof(GameFramework.DataNode.IDataNode));
                    
                    __cl_gen_to_be_invoked.RemoveNode( path, node );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.DataNodeComponent.RemoveNode!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.DataNodeComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DataNodeComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Root(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.DataNodeComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.DataNodeComponent)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, __cl_gen_to_be_invoked.Root);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
