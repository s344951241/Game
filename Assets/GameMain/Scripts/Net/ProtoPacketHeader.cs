using GameFramework;
using GameFramework.Network;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public abstract class ProtoPacketHeader : IPacketHeader, IReference
    {
        public abstract PacketType PacketType
        {
            get;
        }

        public int PacketId
        {
            get;
            set;
        }

        public int PacketLength
        {
            get;
            set;
        }

        public bool IsValid
        {
            get
            {
                return PacketType != PacketType.Undefined && PacketId > 0 /*&& PacketId <= ushort.MaxValue*/ && PacketLength >= 0;
            }
        }

        public void Clear()
        {
            PacketId = 0;
            PacketLength = 0;
        }
    }
}

