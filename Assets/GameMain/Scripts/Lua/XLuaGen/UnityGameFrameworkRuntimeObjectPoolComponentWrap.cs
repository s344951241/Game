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
    public class UnityGameFrameworkRuntimeObjectPoolComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityGameFramework.Runtime.ObjectPoolComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 9, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasObjectPool", _m_HasObjectPool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetObjectPool", _m_GetObjectPool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetObjectPools", _m_GetObjectPools);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllObjectPools", _m_GetAllObjectPools);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateSingleSpawnObjectPool", _m_CreateSingleSpawnObjectPool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateMultiSpawnObjectPool", _m_CreateMultiSpawnObjectPool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DestroyObjectPool", _m_DestroyObjectPool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Release", _m_Release);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReleaseAllUnused", _m_ReleaseAllUnused);
			
			
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
					
					UnityGameFramework.Runtime.ObjectPoolComponent __cl_gen_ret = new UnityGameFramework.Runtime.ObjectPoolComponent();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ObjectPoolComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasObjectPool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ObjectPoolComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ObjectPoolComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.HasObjectPool( objectType );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string fullName = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.HasObjectPool( fullName );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<System.Predicate<GameFramework.ObjectPool.ObjectPoolBase>>(L, 2)) 
                {
                    System.Predicate<GameFramework.ObjectPool.ObjectPoolBase> condition = translator.GetDelegate<System.Predicate<GameFramework.ObjectPool.ObjectPoolBase>>(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.HasObjectPool( condition );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.HasObjectPool( objectType, name );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ObjectPoolComponent.HasObjectPool!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetObjectPool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ObjectPoolComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ObjectPoolComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.GetObjectPool( objectType );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string fullName = LuaAPI.lua_tostring(L, 2);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.GetObjectPool( fullName );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<System.Predicate<GameFramework.ObjectPool.ObjectPoolBase>>(L, 2)) 
                {
                    System.Predicate<GameFramework.ObjectPool.ObjectPoolBase> condition = translator.GetDelegate<System.Predicate<GameFramework.ObjectPool.ObjectPoolBase>>(L, 2);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.GetObjectPool( condition );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.GetObjectPool( objectType, name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ObjectPoolComponent.GetObjectPool!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetObjectPools(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ObjectPoolComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ObjectPoolComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<System.Predicate<GameFramework.ObjectPool.ObjectPoolBase>>(L, 2)) 
                {
                    System.Predicate<GameFramework.ObjectPool.ObjectPoolBase> condition = translator.GetDelegate<System.Predicate<GameFramework.ObjectPool.ObjectPoolBase>>(L, 2);
                    
                        GameFramework.ObjectPool.ObjectPoolBase[] __cl_gen_ret = __cl_gen_to_be_invoked.GetObjectPools( condition );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Predicate<GameFramework.ObjectPool.ObjectPoolBase>>(L, 2)&& translator.Assignable<System.Collections.Generic.List<GameFramework.ObjectPool.ObjectPoolBase>>(L, 3)) 
                {
                    System.Predicate<GameFramework.ObjectPool.ObjectPoolBase> condition = translator.GetDelegate<System.Predicate<GameFramework.ObjectPool.ObjectPoolBase>>(L, 2);
                    System.Collections.Generic.List<GameFramework.ObjectPool.ObjectPoolBase> results = (System.Collections.Generic.List<GameFramework.ObjectPool.ObjectPoolBase>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<GameFramework.ObjectPool.ObjectPoolBase>));
                    
                    __cl_gen_to_be_invoked.GetObjectPools( condition, results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ObjectPoolComponent.GetObjectPools!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllObjectPools(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ObjectPoolComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ObjectPoolComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 1) 
                {
                    
                        GameFramework.ObjectPool.ObjectPoolBase[] __cl_gen_ret = __cl_gen_to_be_invoked.GetAllObjectPools(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool sort = LuaAPI.lua_toboolean(L, 2);
                    
                        GameFramework.ObjectPool.ObjectPoolBase[] __cl_gen_ret = __cl_gen_to_be_invoked.GetAllObjectPools( sort );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<GameFramework.ObjectPool.ObjectPoolBase>>(L, 2)) 
                {
                    System.Collections.Generic.List<GameFramework.ObjectPool.ObjectPoolBase> results = (System.Collections.Generic.List<GameFramework.ObjectPool.ObjectPoolBase>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<GameFramework.ObjectPool.ObjectPoolBase>));
                    
                    __cl_gen_to_be_invoked.GetAllObjectPools( results );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<GameFramework.ObjectPool.ObjectPoolBase>>(L, 3)) 
                {
                    bool sort = LuaAPI.lua_toboolean(L, 2);
                    System.Collections.Generic.List<GameFramework.ObjectPool.ObjectPoolBase> results = (System.Collections.Generic.List<GameFramework.ObjectPool.ObjectPoolBase>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<GameFramework.ObjectPool.ObjectPoolBase>));
                    
                    __cl_gen_to_be_invoked.GetAllObjectPools( sort, results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ObjectPoolComponent.GetAllObjectPools!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateSingleSpawnObjectPool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ObjectPoolComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ObjectPoolComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateSingleSpawnObjectPool( objectType );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    int capacity = LuaAPI.xlua_tointeger(L, 3);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateSingleSpawnObjectPool( objectType, capacity );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateSingleSpawnObjectPool( objectType, expireTime );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    int capacity = LuaAPI.xlua_tointeger(L, 3);
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateSingleSpawnObjectPool( objectType, capacity, expireTime );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    int capacity = LuaAPI.xlua_tointeger(L, 3);
                    int priority = LuaAPI.xlua_tointeger(L, 4);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateSingleSpawnObjectPool( objectType, capacity, priority );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 3);
                    int priority = LuaAPI.xlua_tointeger(L, 4);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateSingleSpawnObjectPool( objectType, expireTime, priority );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    int capacity = LuaAPI.xlua_tointeger(L, 3);
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 4);
                    int priority = LuaAPI.xlua_tointeger(L, 5);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateSingleSpawnObjectPool( objectType, capacity, expireTime, priority );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateSingleSpawnObjectPool( objectType, name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    int capacity = LuaAPI.xlua_tointeger(L, 4);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateSingleSpawnObjectPool( objectType, name, capacity );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateSingleSpawnObjectPool( objectType, name, expireTime );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    int capacity = LuaAPI.xlua_tointeger(L, 4);
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateSingleSpawnObjectPool( objectType, name, capacity, expireTime );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    int capacity = LuaAPI.xlua_tointeger(L, 4);
                    int priority = LuaAPI.xlua_tointeger(L, 5);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateSingleSpawnObjectPool( objectType, name, capacity, priority );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 4);
                    int priority = LuaAPI.xlua_tointeger(L, 5);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateSingleSpawnObjectPool( objectType, name, expireTime, priority );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    int capacity = LuaAPI.xlua_tointeger(L, 4);
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 5);
                    int priority = LuaAPI.xlua_tointeger(L, 6);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateSingleSpawnObjectPool( objectType, name, capacity, expireTime, priority );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    float autoReleaseInterval = (float)LuaAPI.lua_tonumber(L, 4);
                    int capacity = LuaAPI.xlua_tointeger(L, 5);
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 6);
                    int priority = LuaAPI.xlua_tointeger(L, 7);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateSingleSpawnObjectPool( objectType, name, autoReleaseInterval, capacity, expireTime, priority );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ObjectPoolComponent.CreateSingleSpawnObjectPool!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateMultiSpawnObjectPool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ObjectPoolComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ObjectPoolComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateMultiSpawnObjectPool( objectType );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    int capacity = LuaAPI.xlua_tointeger(L, 3);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateMultiSpawnObjectPool( objectType, capacity );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateMultiSpawnObjectPool( objectType, expireTime );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    int capacity = LuaAPI.xlua_tointeger(L, 3);
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateMultiSpawnObjectPool( objectType, capacity, expireTime );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    int capacity = LuaAPI.xlua_tointeger(L, 3);
                    int priority = LuaAPI.xlua_tointeger(L, 4);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateMultiSpawnObjectPool( objectType, capacity, priority );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 3);
                    int priority = LuaAPI.xlua_tointeger(L, 4);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateMultiSpawnObjectPool( objectType, expireTime, priority );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    int capacity = LuaAPI.xlua_tointeger(L, 3);
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 4);
                    int priority = LuaAPI.xlua_tointeger(L, 5);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateMultiSpawnObjectPool( objectType, capacity, expireTime, priority );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateMultiSpawnObjectPool( objectType, name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    int capacity = LuaAPI.xlua_tointeger(L, 4);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateMultiSpawnObjectPool( objectType, name, capacity );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateMultiSpawnObjectPool( objectType, name, expireTime );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    int capacity = LuaAPI.xlua_tointeger(L, 4);
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateMultiSpawnObjectPool( objectType, name, capacity, expireTime );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    int capacity = LuaAPI.xlua_tointeger(L, 4);
                    int priority = LuaAPI.xlua_tointeger(L, 5);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateMultiSpawnObjectPool( objectType, name, capacity, priority );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 4);
                    int priority = LuaAPI.xlua_tointeger(L, 5);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateMultiSpawnObjectPool( objectType, name, expireTime, priority );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 6&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    int capacity = LuaAPI.xlua_tointeger(L, 4);
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 5);
                    int priority = LuaAPI.xlua_tointeger(L, 6);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateMultiSpawnObjectPool( objectType, name, capacity, expireTime, priority );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 7&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    float autoReleaseInterval = (float)LuaAPI.lua_tonumber(L, 4);
                    int capacity = LuaAPI.xlua_tointeger(L, 5);
                    float expireTime = (float)LuaAPI.lua_tonumber(L, 6);
                    int priority = LuaAPI.xlua_tointeger(L, 7);
                    
                        GameFramework.ObjectPool.ObjectPoolBase __cl_gen_ret = __cl_gen_to_be_invoked.CreateMultiSpawnObjectPool( objectType, name, autoReleaseInterval, capacity, expireTime, priority );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ObjectPoolComponent.CreateMultiSpawnObjectPool!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DestroyObjectPool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ObjectPoolComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ObjectPoolComponent)translator.FastGetCSObj(L, 1);
            
            
			    int __gen_param_count = LuaAPI.lua_gettop(L);
            
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.DestroyObjectPool( objectType );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<GameFramework.ObjectPool.ObjectPoolBase>(L, 2)) 
                {
                    GameFramework.ObjectPool.ObjectPoolBase objectPool = (GameFramework.ObjectPool.ObjectPoolBase)translator.GetObject(L, 2, typeof(GameFramework.ObjectPool.ObjectPoolBase));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.DestroyObjectPool( objectPool );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    System.Type objectType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string name = LuaAPI.lua_tostring(L, 3);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.DestroyObjectPool( objectType, name );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityGameFramework.Runtime.ObjectPoolComponent.DestroyObjectPool!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Release(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ObjectPoolComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ObjectPoolComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Release(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReleaseAllUnused(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityGameFramework.Runtime.ObjectPoolComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ObjectPoolComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.ReleaseAllUnused(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Count(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityGameFramework.Runtime.ObjectPoolComponent __cl_gen_to_be_invoked = (UnityGameFramework.Runtime.ObjectPoolComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.Count);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
