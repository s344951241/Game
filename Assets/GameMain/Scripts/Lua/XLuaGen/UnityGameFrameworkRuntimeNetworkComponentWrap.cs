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
    public class UnityGameFrameworkRuntimeNetworkComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityGameFramework.Runtime.NetworkComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasNetworkChannel", _m_HasNetworkChannel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetNetworkChannel", _m_GetNetworkChannel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllNetworkChannels", _m_GetAllNetworkChannels);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateNetworkChannel", _m_CreateNetworkChannel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DestroyNetworkChannel", _m_DestroyNetworkChannel);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "NetworkChannelCount", _g_get_NetworkChannelCount);
            
			
			
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
					
					UnityGameFramework.Runtime.NetworkComponent __cl_gen_ret = new UnityGameFramework.Runtime.NetworkComponent();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.NetworkComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasNetworkChannel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.NetworkComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.NetworkComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.HasNetworkChannel( name );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNetworkChannel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.NetworkComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.NetworkComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        GameFramework.Network.INetworkChannel __cl_gen_ret = __cl_gen_to_be_invoked.GetNetworkChannel( name );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllNetworkChannels(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.NetworkComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.NetworkComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                        GameFramework.Network.INetworkChannel[] __cl_gen_ret = __cl_gen_to_be_invoked.GetAllNetworkChannels(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<GameFramework.Network.INetworkChannel>>(L, 2)) 
                {
                    System.Collections.Generic.List<GameFramework.Network.INetworkChannel> results = (System.Collections.Generic.List<GameFramework.Network.INetworkChannel>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<GameFramework.Network.INetworkChannel>));
                    
                    __cl_gen_to_be_invoked.GetAllNetworkChannels( results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.NetworkComponent.GetAllNetworkChannels!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateNetworkChannel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.NetworkComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.NetworkComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    GameFramework.Network.INetworkChannelHelper networkChannelHelper = (GameFramework.Network.INetworkChannelHelper)translator.GetObject(L, 3, typeof(GameFramework.Network.INetworkChannelHelper));
                    
                        GameFramework.Network.INetworkChannel __cl_gen_ret = __cl_gen_to_be_invoked.CreateNetworkChannel( name, networkChannelHelper );
                        translator.PushAny(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DestroyNetworkChannel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.NetworkComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.NetworkComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.DestroyNetworkChannel( name );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_NetworkChannelCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.NetworkComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.NetworkComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.NetworkChannelCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
