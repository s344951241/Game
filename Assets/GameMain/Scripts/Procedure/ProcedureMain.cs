using System.Collections;
using System.Collections.Generic;
using GameFramework;
using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace Game
{
    public class ProcedureMain : ProcedureBase
    {
        private TestLoad m_Load = null;
        public override bool UseNativeDialog
        {
            get
            {
                return false;
            }
        }

        protected internal override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);
            m_Load = new TestLoad();
        }

        protected internal override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
            //测试
            if (Input.GetKeyDown(KeyCode.L))
            {

                m_Load.CreateEntity();
                Debug.LogError(SkillVO.GetConfig(1).Name);
                LuaEventArgs arg = ReferencePool.Acquire<LuaEventArgs>().Fill("Main");
                arg.IntArgs[0] = 1;
                arg.IntArgs[1] = 2;
                GameEntry.Event.Fire(this, arg);
            }
        }

        public override string LuaScriptName
        {
            get
            {
                return "Procedure/ProcedureMain";
            }
        }

    }
}

