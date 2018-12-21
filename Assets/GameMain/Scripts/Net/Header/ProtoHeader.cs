using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace Game
{
    public class ProtoHeader : ProtoPacketHeader
    {
        public const int Length = sizeof(uint)+ sizeof(int) + sizeof(int);

        private byte[] _buffer = new byte[Length];

        public int HeadLength
        {
            get
            {
                return Length;
            }
        }
        public bool Serialize(Stream stream)
        {
            if (stream == null)
            {
                Log.Warning("Stream is invalid.");
                return false;
            }

            if (!stream.CanWrite)
            {
                Log.Warning("Stream can not write.");
                return false;
            }
            _buffer[0] = (byte)(uint)PacketLength;
            _buffer[1] = (byte)((uint)PacketLength >> 8);
            _buffer[2] = (byte)((uint)PacketLength >> 16);
            _buffer[3] = (byte)((uint)PacketLength >> 24);

            //检验，没用先
            _buffer[4] = 0;
            _buffer[5] = 0;
            _buffer[6] = 0;
            _buffer[7] = 0;

            _buffer[8] = (byte)PacketId;
            _buffer[9] = (byte)(PacketId >> 8);
            _buffer[10] = (byte)(PacketId >> 16);
            _buffer[11] = (byte)(PacketId >> 24);

            stream.Position = 0;
            stream.Write(_buffer, 0, Length);
            return true;
        }

        public bool Deserialize(Stream stream)
        {
            if (stream == null)
            {
                Log.Warning("Stream is invalid.");
                return false;
            }
            if(!stream.CanRead)
            {
                Log.Warning("Stream can not write.");
                return false;
            }
            if (stream.Length < Length)
            {
                Log.Warning("Stream length is invalid.");
                return false;
            }

            PacketLength = (stream.ReadByte() | (stream.ReadByte() << 8) | (stream.ReadByte() << 16) | (stream.ReadByte() << 24));

            stream.ReadByte();
            stream.ReadByte();
            stream.ReadByte();
            stream.ReadByte();

            PacketId = (stream.ReadByte() | (stream.ReadByte() << 8) | (stream.ReadByte() << 16) | (stream.ReadByte() << 24));
            Debug.LogError("反序列化出来的id" + PacketId);
            return true;

        }

        public override PacketType PacketType
        {
            get
            {
                return PacketType.Proto;
            }
        }
    }

}
