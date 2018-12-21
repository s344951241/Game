using GameFramework.Network;
using ProtoBuf;

namespace Game
{
    public class ProtoPacket : Packet
    {
        private int _msgId;
        private IExtensible _msg;

        public ProtoPacket(int id, IExtensible msg)
        {
            _msgId = id;
            _msg = msg;
        }

        public ProtoPacket()
        {

        }
        public override int Id
        {
            get
            {
                return _msgId;
            }
        }

        public void SetId(int id)
        {
            _msgId = id;
            UnityEngine.Debug.Log("设置id" + Id);
        }

        public void SetObj(IExtensible proto)
        {
            _msg = proto;
        }
        public IExtensible MsgObj
        {
            get { return _msg; }
        }
        public override void Clear()
        {
            _msg = null;
        }
        public PacketType PacketType
        {
            get;
            set;
        }
    }
}

