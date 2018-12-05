using GameFramework;
using GameFramework.Network;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class ProtoPacketHeader : IPacketHeader, IReference
    {
        public const int FS_LENGTH = 2;
        public const int FS_CHECK = 4;
        public const int FS_MSGID = 4;
        public const int HEADER_SIZE = FS_LENGTH + FS_CHECK + FS_MSGID;

        public PacketType PacketType
        {
            get;
            set;
        }
        public int PacketLength{get;set; }
        public int Check { get; set; }
        public int ProtoId { set; get; }
        public void Clear()
        {
            
        }
    }
}

