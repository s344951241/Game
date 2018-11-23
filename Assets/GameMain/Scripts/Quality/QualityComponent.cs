using UnityEngine;
using UnityGameFramework.Runtime;

namespace Game
{
    [DisallowMultipleComponent]
    public class QualityComponent : GameFrameworkComponent
    {
        public QualityLevelType CurrentQualityLevel
        {
            get
            {
                return (QualityLevelType)QualitySettings.GetQualityLevel();
            }
        }

        public QualityLevelType? SettingQualityLevel
        {
            get
            {
                if (!GameEntry.Setting.HasSetting(Constant.Setting.QualityLevel))
                {
                    return null;
                }

                return (QualityLevelType)GameEntry.Setting.GetInt(Constant.Setting.QualityLevel, (int)QualityLevelType.VeryLow);
            }
        }

        public bool InternalFeatureEnabled
        {
            get
            {
                return GameEntry.Setting.GetBool(Constant.Setting.InternalFeature, false);
            }
            set
            {
                GameEntry.Setting.SetBool(Constant.Setting.InternalFeature, value);
                GameEntry.Setting.Save();
            }
        }

        public void SetQualityLevel(QualityLevelType qualityLevel, bool save = false)
        {
            if (CurrentQualityLevel != qualityLevel)
            {
                QualitySettings.SetQualityLevel((int)qualityLevel, true);
            }

            if (save)
            {
                GameEntry.Setting.SetInt(Constant.Setting.QualityLevel, (int)qualityLevel);
                GameEntry.Setting.Save();
            }
        }
    }
}
