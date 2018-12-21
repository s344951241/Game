using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LengthTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.LogError("byte size"+(sizeof(byte)));
        Debug.LogError("ushort size"+sizeof(ushort));
        Debug.LogError("short size"+sizeof(short));
        Debug.LogError("uint size"+sizeof(uint));
        Debug.LogError("int size"+sizeof(int));

        int length = 15;
        int id = 19954;


        int len = sizeof(int) + sizeof(int) + sizeof(int);

        byte[] buff = new byte[len];

        buff[0] = (byte)(uint)length;
        buff[1] = (byte)((uint)length >> 8);
        buff[2] = (byte)((uint)length >> 16);
        buff[3] = (byte)((uint)length >> 24);

        //检验，没用先
        buff[4] = 0;
        buff[5] = 0;
        buff[6] = 0;
        buff[7] = 0;

        buff[8] = (byte)id;
        buff[9] = (byte)(id >> 8);
        buff[10] = (byte)(id >> 16);
        buff[11] = (byte)(id >> 24);
        Stream stream = new MemoryStream();
        stream.Position = 0;
        stream.Write(buff, 0, len);
        stream.Position = 0;
        int int1 = stream.ReadByte();
        int int2 = stream.ReadByte();
        int int3 = stream.ReadByte();
        int int4 = stream.ReadByte();

        int PacketLength = (int1 | (int2 << 8) | (int3 << 16) | (int4 << 24));
        Debug.LogError(PacketLength);
        stream.ReadByte();
        stream.ReadByte();
        stream.ReadByte();
        stream.ReadByte();

        int PacketId = (stream.ReadByte() | (stream.ReadByte() << 8) | (stream.ReadByte() << 16) | (stream.ReadByte() << 24));
        Debug.LogError(PacketId);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
