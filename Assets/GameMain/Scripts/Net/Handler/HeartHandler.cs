using System.Collections;
using System.Collections.Generic;
using GameFramework.Network;
using UnityEngine;

namespace Game
{
    public class HeartHandler : ProtoHandler
    {
        public override int Id
        {
            get
            {
                return CRC16.GetCRC16(typeof(ProtoBuf.Heart).FullName);
            }
        }

        public override void Handle(object sender, Packet packet)
        {
            ProtoPacket proto = packet as ProtoPacket;
            ProtoBuf.Heart hear = proto.MsgObj as ProtoBuf.Heart;
            Debug.LogError("返回心跳包:" + hear.time);
        }
    }

}
