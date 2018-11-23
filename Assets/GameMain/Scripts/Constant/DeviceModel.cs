using System;
using UnityEngine;

namespace Game
{
    [Serializable]
    public class DeviceModel
    {
        [SerializeField]
        private string m_DeviceName = null;

        [SerializeField]
        private string m_ModelName = null;

        [SerializeField]
        private QualityLevelType m_QualityLevel = QualityLevelType.VeryLow;

        public string DeviceName
        {
            get
            {
                return m_DeviceName;
            }
        }

        public string ModelName
        {
            get
            {
                return m_ModelName;
            }
        }

        public QualityLevelType QualityLevel
        {
            get
            {
                return m_QualityLevel;
            }
        }
    }
}
