using GameFramework.Network;

namespace Game
{
    public abstract class ProtoHandler : IPacketHandler
    {
        public abstract int Id
        {
            get;
        }

        public abstract void Handle(object sender, Packet packet);
    }
}
