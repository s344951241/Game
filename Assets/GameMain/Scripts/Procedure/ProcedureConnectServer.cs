using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
namespace Game
{
    public class ProcedureConnectServer : ProcedureBase
    {
        private GameFramework.Network.INetworkChannel m_Channel;
        private NetworkChannelHelper m_NetworkChannelHelper;
        public override bool UseNativeDialog
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        protected internal override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            //Demo8_SocketServer.Start();
            m_NetworkChannelHelper = new NetworkChannelHelper();
            m_Channel = GameEntry.Network.CreateNetworkChannel("testName", m_NetworkChannelHelper);
            m_Channel.Connect(IPAddress.Parse("127.0.0.1"), 8098);
        }

    }
}

