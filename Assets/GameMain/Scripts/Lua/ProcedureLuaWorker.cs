using System;
using UnityGameFramework.Runtime;
using XLua;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace Game
{
    /// <summary>
    /// 将C#的Procedure逻辑处理转嫁到Lua中</summary>
    /// <remarks>
    ///
    /// </remarks>
    [XLua.LuaCallCSharp]
    public class ProcedureLuaWorker
    {
        [CSharpCallLua]
        public delegate void DelegateOnNotify(LuaTable self, object param0, object param1);

        [CSharpCallLua]
        public delegate void DelegateOnEnter(LuaTable self, ProcedureOwner procedureOwner);

        [CSharpCallLua]
        public delegate void DelegateOnLeave(LuaTable self, ProcedureOwner procedureOwner, bool isShutdown);

        [CSharpCallLua]
        public delegate void DelegateOnUpdate(LuaTable self, ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds);

        [CSharpCallLua]
        public delegate void DelegateOnDestroy(LuaTable self, ProcedureOwner procedureOwner);

        public LuaTable Script { get { return _script; } }

        private LuaTable _scriptEnv = null;
        private LuaTable _script = null;

        private DelegateOnNotify _luaOnNotify = null;
        private DelegateOnEnter _luaOnEnter = null;
        private DelegateOnLeave _luaOnLeave = null;
        private DelegateOnUpdate _luaOnUpdate = null;
        private DelegateOnDestroy _luaOnDestroy = null;

        /// <summary>
        /// 构造函数.</summary>
        /// <param name="target"> 要转嫁的目标Procedure.</param>
        /// <param name="scriptFile"> 对应的Lua版Procedure脚本.</param>
        public ProcedureLuaWorker(ProcedureBase target, string scriptName)
        {
            try
            {
                _scriptEnv = GameEntry.Lua.NewTable();
                object[] objs = GameEntry.Lua.DoScript(scriptName, scriptName, _scriptEnv);
                _script = objs[0] as LuaTable;
                _script.Set("C#", target);
                _script.Get("OnNotify", out _luaOnNotify);
                _script.Get("OnEnter", out _luaOnEnter);
                _script.Get("OnLeave", out _luaOnLeave);
                _script.Get("OnUpdate", out _luaOnUpdate);
                _script.Get("OnDestroy", out _luaOnDestroy);
            }
            catch (SystemException e)
            {
                Log.Error("ProcedureLuaWorker.Initialize failed: " + e.Message);
                Cleanup();
            }
        }

        /// <summary>
        /// 最后清理.</summary>
        public void Cleanup()
        {
            _luaOnNotify = null;
            _luaOnEnter = null;
            _luaOnLeave = null;
            _luaOnUpdate = null;
            _luaOnDestroy = null;
            _script = null;

            if (_scriptEnv != null)
            {
                _scriptEnv.Dispose();
            }

            _scriptEnv = null;
        }

        /// <summary>
        /// 发送一个通知给脚本.</summary>
        /// <param name="param0"> 自定义参数0.</param>
        /// <param name="param1"> 自定义参数1.</param>
        public void NotifyScript(object param0, object param1 = null)
        {
            if (_luaOnNotify != null)
            {
                _luaOnNotify(_script, param0, param1);
            }
        }

        /// <summary>
        /// 对Procedure的OnDestroy的回调接口.</summary>
        public void OnDestroy(ProcedureOwner procedureOwner)
        {
            if (_luaOnDestroy != null)
            {
                _luaOnDestroy(_script, procedureOwner);
            }
        }

        /// <summary>
        /// 对Procedure的OnEnter的回调接口.</summary>
        public void OnEnter(ProcedureOwner procedureOwner)
        {
            if (_luaOnEnter != null)
            {
                _luaOnEnter(_script, procedureOwner);
            }
        }

        /// <summary>
        /// 对Procedure的OnLeave的回调接口.</summary>
        public void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
        {
            if (_luaOnLeave != null)
            {
                _luaOnLeave(_script, procedureOwner, isShutdown);
            }
        }

        /// <summary>
        /// 对Procedure的OnUpdate的回调接口.</summary>
        public void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            if (_luaOnUpdate != null)
            {
                _luaOnUpdate(_script, procedureOwner, elapseSeconds, realElapseSeconds);
            }
        }

    }
}
