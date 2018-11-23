using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Editor.AssetBundleTools;

namespace ProjectS.Editor
{
    public class BundleSwitch
    {
        public const string wwAndroid = "Android";
        public const string wwIos = "iOS";
        public const string wwMac = "Mac";
        public const string wwWindows = "Windows";


        public const string wwChinese = "Chines";

        private Dictionary<Platform, string> m_WwisePlatform;
        //TODO 语言
        private static BundleSwitch instance;

        public static BundleSwitch Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BundleSwitch();
                }
                return instance;
            }

        }

        private BundleSwitch()
        {
            m_WwisePlatform = new Dictionary<Platform, string>();
            m_WwisePlatform.Add(Platform.Android, wwAndroid);
            m_WwisePlatform.Add(Platform.IOS, wwIos);
            m_WwisePlatform.Add(Platform.MacOS,wwMac);
            m_WwisePlatform.Add(Platform.Windows64, wwWindows);
        }

        public string WwiseGetPlatformString(Platform plat)
        {
            string result = "";
            m_WwisePlatform.TryGetValue(plat, out result);

            if (string.IsNullOrEmpty(result))
            {
                return wwWindows;
            }
            else
            {
                return result;
            }
        }

        public bool PathInSwitch(string path)
        {
            foreach (var str in m_WwisePlatform)
            {
                if (path.Contains(str.Value))
                {
                    return true;
                }
            }
            return false;
        }
    }

    
}
