namespace Game
{
    public enum PacketType:byte
    {
        /// <summary>
        /// 未定义。
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// 基于 ProtoBuf 的上行消息包。
        /// </summary>
        UpwardPacket,

        /// <summary>
        /// 基于 ProtoBuf 的下行消息包。
        /// </summary>
        DownwardPacket,
        /// <summary>
        /// 不区分两端的proto
        /// </summary>
        Proto,
    }

}
