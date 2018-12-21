using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace Game
{
    public class UpProtoHeader : ProtoPacketHeader
    {
        public const int Length = sizeof(int) + sizeof(byte) + sizeof(byte) + sizeof(short) + sizeof(int);
        private static readonly byte[] _buffer = new byte[Length];
        private static uint _serialId;
        public override PacketType PacketType
        {
            get
            {
                return PacketType.UpwardPacket;
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

            uint serialId = ++_serialId;

            if (PacketId > ushort.MaxValue)
            {
                Log.Warning("Packet id is invalid.");
                return false;
            }

            _buffer[0] = (byte)serialId;
            _buffer[1] = (byte)(serialId >> 8);
            _buffer[2] = (byte)(serialId >> 16);
            _buffer[3] = (byte)(serialId >> 24);

            _buffer[4] = 0; // 占位，无意义
            _buffer[5] = 0; // 占位，无意义

            _buffer[6] = (byte)(ushort)PacketId;
            _buffer[7] = (byte)((ushort)PacketId >> 8);

            _buffer[8] = (byte)(uint)PacketLength;
            _buffer[9] = (byte)((uint)PacketLength >> 8);
            _buffer[10] = (byte)((uint)PacketLength >> 16);
            _buffer[11] = (byte)((uint)PacketLength >> 24);

            stream.Position = 0L;
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
            _serialId = (uint)(stream.ReadByte() | (stream.ReadByte() << 8) | (stream.ReadByte() << 16) | (stream.ReadByte() << 24));
            Debug.LogError("_serialId" + _serialId);
            stream.ReadByte();
          
            stream.ReadByte();
            PacketId = (ushort)(stream.ReadByte() | (stream.ReadByte() << 8));
            Debug.LogError("PacketId" + PacketId);
            PacketLength = (stream.ReadByte() | (stream.ReadByte() << 8) | (stream.ReadByte() << 16) | (stream.ReadByte() << 24));
            Debug.LogError("PacketLength" + PacketLength);
            return true;
        }

        public static void ResetSerialId()
        {
            _serialId = 0;
        }
    }

}
