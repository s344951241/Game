using System;

namespace Game
{
    [Serializable]
    public class BuildInfo
    {
        public int InternalGameVersion;
        public int SvnVersion;
        public string SvnBranch;
        public string SvnLastChangedTime;
        public string LogHelperName;
        public string CheckVersionUrl;
        public string StandaloneAppUrl;
        public string IosAppUrl;
        public string AndroidAppUrl;
    }
}
