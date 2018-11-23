using System;

namespace Game
{
    [Serializable]
    public class VersionInfo
    {
        public bool ForceGameUpdate;

        public string LatestGameVersion;

        public int InternalApplicationVersion;

        public int InternalResourceVersion;

        public string GameUpdateUrl;

        public int VersionListLength;

        public int VersionListHashCode;

        public int VersionListZipLength;

        public int VersionListZipHashCode;
    }
}
