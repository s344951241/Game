﻿using ProtoBuf;
using ProtoBuf.Meta;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Game
{
    public class ProtoSerialize
    {
        static int size = 0;
        public static byte[] SerializeProto(IExtensible proto)
        {
            byte[] pbdata = Serialize(proto);
            ushort len = (ushort)pbdata.Length;
            ByteBuffer buff = ByteBuffer.Allocate(len + size);
            buff.WriteUshort((ushort)(len + size));
            buff.WriteInt(0);
            buff.WriteUint(CRC32.GetCRC32(proto.GetType().FullName));
            buff.WriteBytes(pbdata);
            return buff.ToArray();
        }

        public static byte[] SerializeProto(uint msgId, byte[] bytes)
        {
            ushort len = (ushort)bytes.Length;
            ByteBuffer buff = ByteBuffer.Allocate(len + size);
            buff.WriteUshort((ushort)(len + size));
            buff.WriteInt(0);
            buff.WriteUint(msgId);
            buff.WriteBytes(bytes);
            return buff.ToArray();
        }
        public static void DeserializeProto(byte[] byteIn, out byte[] byteOut, out int leng, out int check, out uint id)
        {
            ByteBuffer buff = ByteBuffer.Allocate(byteIn);
            leng = buff.ReadUshort();
            check = buff.ReadInt();
            id = buff.ReadUint();
            byteOut = new byte[leng - size];
            buff.ReadBytes(byteOut, 0, leng - size);
        }
        public static byte[] Serialize<T>(T msg)
        {
            byte[] result = null;
            if (msg != null)
            {
                using (var stream = new MemoryStream())
                {
                    Serializer.Serialize<T>(stream, msg);
                    result = stream.ToArray();
                }
            }
            return result;
        }

        public static T Deserialize<T>(byte[] message)
        {
            T result = default(T);
            if (message != null)
            {
                using (var stream = new MemoryStream(message))
                {
                    result = Serializer.Deserialize<T>(stream);
                }
            }
            return result;


        }

        public static object Deserialize(byte[] message, Type type)
        {
            object result = null;
            if (message != null)
            {
                using (var stream = new MemoryStream())
                {
                    result = RuntimeTypeModel.Default.Deserialize(stream, null, type);
                }
            }
            return result;
        }
    }
}

