namespace Game
{
    public static class StreamUtility
    {
        private const byte PacketStreamMask = 0xf0;

        public static byte[] Process(byte[] stream)
        {
            if (stream == null)
            {
                return null;
            }

            return Process(stream, 0, stream.Length);
        }

        public static byte[] Process(byte[] stream, int index, int length)
        {
            if (stream == null)
            {
                return null;
            }

            for (int i = index; i < length; i++)
            {
                stream[i] ^= PacketStreamMask;
            }

            return stream;
        }

        public static byte Process(byte value)
        {
            return (byte)(value ^ PacketStreamMask);
        }
    }
}
