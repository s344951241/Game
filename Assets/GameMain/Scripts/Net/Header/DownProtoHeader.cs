using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace Game
{
    public sealed class DownProtoHeader : ProtoPacketHeader
    {
        public const int Length = sizeof(short) + sizeof(int);

        public override PacketType PacketType
        {
            get
            {
                return PacketType.DownwardPacket;
            }
        }
        public bool Deserialize(Stream stream)
        {
            Debug.LogError("进来了");
            if (stream == null)
            {
                Log.Warning("Stream is invalid.");
                return false;
            }

            if (!stream.CanRead)
            {
                Log.Warning("Stream can not write.");
                return false;
            }

            if (stream.Length < Length)
            {
                Log.Warning("Stream length is invalid.");
                return false;
            }

            PacketId = (ushort)(StreamUtility.Process((byte)stream.ReadByte()) | (StreamUtility.Process((byte)stream.ReadByte()) << 8));
            //PacketId = (stream.ReadByte() | (stream.ReadByte() << 8));
            // 最后一个 byte 是废弃的，不要读，包长只用 3 个字节表示
            //PacketLength = stream.ReadByte() | (stream.ReadByte() << 8) | (stream.ReadByte() << 16);
            PacketLength = (((StreamUtility.Process((byte)stream.ReadByte()) | (StreamUtility.Process((byte)stream.ReadByte()) << 8)) | (StreamUtility.Process((byte)stream.ReadByte()) << 16)));
            Log.Error(PacketId+"|"+PacketLength);
            return true;
        }
    }
}

