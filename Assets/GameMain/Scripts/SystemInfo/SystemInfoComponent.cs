using Game;
using GameFramework.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace Game
{
    [DisallowMultipleComponent]
    public sealed class SystemInfoComponent : GameFrameworkComponent
    {
        public sealed class DeviceInfo
        {
            public DeviceInfo()
            {
                DeviceUniqueId = SystemInfo.deviceUniqueIdentifier;
                DeviceName = SystemInfo.deviceName;
                DeviceModel = SystemInfo.deviceModel;
                Platform = Application.platform;
            }

            /// <summary>
            /// 获取设备唯一编号。
            /// </summary>
            public string DeviceUniqueId
            {
                get;
                private set;
            }

            /// <summary>
            /// 获取设备名称。
            /// </summary>
            public string DeviceName
            {
                get;
                private set;
            }

            /// <summary>
            /// 获取设备类型。
            /// </summary>
            public string DeviceModel
            {
                get;
                private set;
            }

            /// <summary>
            /// 获取平台。
            /// </summary>
            public RuntimePlatform Platform
            {
                get;
                private set;
            }

            /// <summary>
            /// 获取网络是否连通。
            /// </summary>
            public NetworkReachability InternetReachability
            {
                get;
                private set;
            }
            /// <summary>
            /// 获取电池状态。
            /// </summary>
            public BatteryStatus BatteryStatus
            {
                get
                {
                    return SystemInfo.batteryStatus;
                }
            }
            /// <summary>
            /// 获取电池电量。
            /// </summary>
            public float BatteryLevel
            {
                get
                {
                    return SystemInfo.batteryLevel;
                }
            }

            /// <summary>
            /// 获取设备时间。
            /// </summary>
            public DateTime DeviceTime
            {
                get
                {
                    return DateTime.Now;
                }
            }

            /// <summary>
            /// 获取设备 UTC 时间。
            /// </summary>
            public DateTime DeviceUtcTime
            {
                get
                {
                    return DateTime.UtcNow;
                }
            }
        }

        public sealed class CpuInfo
        {
            public CpuInfo()
            {
                ProcessorType = SystemInfo.processorType;
                ProcessorCount = SystemInfo.processorCount;
                ProcessorFrequency = SystemInfo.processorFrequency;
            }

            /// <summary>
            /// 获取处理器类型。
            /// </summary>
            public string ProcessorType
            {
                get;
                private set;
            }

            /// <summary>
            /// 获取处理器数量。
            /// </summary>
            public int ProcessorCount
            {
                get;
                private set;
            }

            /// <summary>
            /// 获取处理器主频。
            /// </summary>
            public int ProcessorFrequency
            {
                get;
                private set;
            }
        }

        public sealed class MemoryInfo
        {
            public MemoryInfo()
            {
                SystemMemorySize = SystemInfo.systemMemorySize;
                GraphicsMemorySize = SystemInfo.graphicsMemorySize;
            }

            /// <summary>
            /// 获取内存。
            /// </summary>
            public int SystemMemorySize
            {
                get;
                private set;
            }

            /// <summary>
            /// 获取显存。
            /// </summary>
            public int GraphicsMemorySize
            {
                get;
                private set;
            }
        }
        public sealed class ScreenInfo
        {
            public ScreenInfo()
            {
                ScreenWidth = UnityEngine.Screen.width;
                ScreenHeight = UnityEngine.Screen.height;
                ScreenDpi = UnityEngine.Screen.dpi;
            }

            /// <summary>
            /// 获取屏幕宽度。
            /// </summary>
            public int ScreenWidth
            {
                get;
                private set;
            }

            /// <summary>
            /// 获取屏幕高度。
            /// </summary>
            public int ScreenHeight
            {
                get;
                private set;
            }

            /// <summary>
            /// 获取屏幕点密度。
            /// </summary>
            public float ScreenDpi
            {
                get;
                private set;
            }
        }

        public sealed class SoftwareInfo
        {
            public SoftwareInfo()
            {
                GameFrameworkVersion = GameFramework.Version.GameFrameworkVersion;
                GameVersion = GameFramework.Version.GameVersion;
                InternalGameVersion = GameFramework.Version.InternalGameVersion;
                UnityVersion = Application.unityVersion;
                OperatingSystem = SystemInfo.operatingSystem;
                SystemLanguage = Application.systemLanguage;
            }
            /// <summary>
            /// 获取游戏框架版本号。
            /// </summary>
            public string GameFrameworkVersion
            {
                get;
                private set;
            }
            /// <summary>
            /// 获取游戏版本号。
            /// </summary>
            public string GameVersion
            {
                get;
                private set;
            }
            /// <summary>
            /// 获取内部游戏版本号。
            /// </summary>
            public int InternalGameVersion
            {
                get;
                private set;
            }
            /// <summary>
            /// 获取当前资源适用的游戏版本号。
            /// </summary>
            public string ApplicableGameVersion
            {
                get
                {
                    return GameEntry.Resource.ApplicableGameVersion;
                }
            }
            /// <summary>
            /// 获取当前内部资源版本号。
            /// </summary>
            public int InternalResourceVersion
            {
                get
                {
                    return GameEntry.Resource.InternalResourceVersion;
                }
            }

            /// <summary>
            /// 获取操作系统。
            /// </summary>
            public string OperatingSystem
            {
                get;
                private set;
            }

            /// <summary>
            /// 获取 Unity 版本。
            /// </summary>
            public string UnityVersion
            {
                get;
                private set;
            }
            /// <summary>
            /// 获取系统语言。
            /// </summary>
            public SystemLanguage SystemLanguage
            {
                get;
                private set;
            }

            /// <summary>
            /// 获取当前语言。
            /// </summary>
            public Language Language
            {
                get
                {
                    return GameEntry.Localization.Language;
                }
            }

            /// <summary>
            /// 获取运行时间。
            /// </summary>
            public float RealtimeSinceStartup
            {
                get
                {
                    return Time.realtimeSinceStartup;
                }
            }
        }

        private DeviceInfo m_DeviceInfo = null;
        private CpuInfo m_CpuInfo = null;
        private MemoryInfo m_MemoryInfo = null;
        private ScreenInfo m_ScreenInfo = null;
        private SoftwareInfo m_SoftwareInfo = null;

        /// <summary>
        /// 获取设备信息。
        /// </summary>
        public DeviceInfo Device
        {
            get
            {
                return m_DeviceInfo;
            }
        }

        /// <summary>
        /// 获取 CPU 信息。
        /// </summary>
        public CpuInfo Cpu
        {
            get
            {
                return m_CpuInfo;
            }
        }

        /// <summary>
        /// 获取内存信息。
        /// </summary>
        public MemoryInfo Memory
        {
            get
            {
                return m_MemoryInfo;
            }
        }

        /// <summary>
        /// 获取屏幕信息。
        /// </summary>
        public ScreenInfo Screen
        {
            get
            {
                return m_ScreenInfo;
            }
        }

        /// <summary>
        /// 获取软件信息。
        /// </summary>
        public SoftwareInfo Software
        {
            get
            {
                return m_SoftwareInfo;
            }
        }

        /// <summary>
        /// 获取系统信息。
        /// </summary>
        /// <param name="dictionaryResults"></param>
        /// <param name="stringResult"></param>
        /// <remarks>注意：传入的 Dictionary 或 StringBuilder 需要自行清除旧值。</remarks>
        public void GenerateValues(Dictionary<string, string> dictionaryResults, StringBuilder stringResult)
        {
            if (dictionaryResults == null && stringResult == null)
            {
                Log.Warning("Results is invalid.");
                return;
            }

            if (stringResult != null)
            {
                stringResult.AppendLine();
            }

            AddTitle(stringResult, "DeviceInfo");
            AddValue(dictionaryResults, stringResult, "DeviceUniqueId", Device.DeviceUniqueId);
            AddValue(dictionaryResults, stringResult, "DeviceName", Device.DeviceName);
            AddValue(dictionaryResults, stringResult, "DeviceModel", Device.DeviceModel);
            AddValue(dictionaryResults, stringResult, "Platform", Device.Platform.ToString());
            AddValue(dictionaryResults, stringResult, "InternetReachability", Device.InternetReachability.ToString());
            AddValue(dictionaryResults, stringResult, "BatteryStatus", Device.BatteryStatus.ToString());
            AddValue(dictionaryResults, stringResult, "BatteryLevel", Device.BatteryLevel < 0f ? "Unavailable" : Device.BatteryLevel.ToString("P0"));
            AddValue(dictionaryResults, stringResult, "DeviceTime", Device.DeviceTime.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            AddValue(dictionaryResults, stringResult, "DeviceUtcTime", Device.DeviceUtcTime.ToString("yyyy-MM-dd HH:mm:ss.fff"));

            AddTitle(stringResult, "HardwareInfo");
            AddValue(dictionaryResults, stringResult, "ProcessorType", Cpu.ProcessorType);
            AddValue(dictionaryResults, stringResult, "ProcessorCount", Cpu.ProcessorCount.ToString());
            AddValue(dictionaryResults, stringResult, "ProcessorFrequency", Cpu.ProcessorFrequency.ToString());
            AddValue(dictionaryResults, stringResult, "SystemMemorySize", Memory.SystemMemorySize.ToString());
            AddValue(dictionaryResults, stringResult, "GraphicsMemorySize", Memory.GraphicsMemorySize.ToString());
            AddValue(dictionaryResults, stringResult, "ScreenWidth", Screen.ScreenWidth.ToString());
            AddValue(dictionaryResults, stringResult, "ScreenHeight", Screen.ScreenHeight.ToString());
            AddValue(dictionaryResults, stringResult, "ScreenDpi", Screen.ScreenDpi.ToString());

            AddTitle(stringResult, "SoftwareInfo");
            AddValue(dictionaryResults, stringResult, "GameFrameworkVersion", Software.GameFrameworkVersion);
            AddValue(dictionaryResults, stringResult, "GameVersion", Software.GameVersion);
            AddValue(dictionaryResults, stringResult, "InternalGameVersion", Software.InternalGameVersion.ToString());
            AddValue(dictionaryResults, stringResult, "ApplicableGameVersion", GameEntry.Base.EditorResourceMode ? "Unavailable" : Software.ApplicableGameVersion == null ? "null" : Software.ApplicableGameVersion);
            AddValue(dictionaryResults, stringResult, "InternalResourceVersion", GameEntry.Base.EditorResourceMode ? "Unavailable" : Software.InternalResourceVersion.ToString());
            AddValue(dictionaryResults, stringResult, "UnityVersion", Software.UnityVersion);
            AddValue(dictionaryResults, stringResult, "OperatingSystem", Software.OperatingSystem);
            AddValue(dictionaryResults, stringResult, "SystemLanguage", Software.SystemLanguage.ToString());
            AddValue(dictionaryResults, stringResult, "Language", Software.Language.ToString());
            AddValue(dictionaryResults, stringResult, "RealtimeSinceStartup", Software.RealtimeSinceStartup.ToString());

            AddTitle(stringResult, "SvnInfo");
            BuildInfo buildInfo = GameEntry.BuiltinData.BuildInfo;
            AddValue(dictionaryResults, stringResult, "SvnVersion", buildInfo == null ? "Unavailable" : buildInfo.SvnVersion.ToString());
            AddValue(dictionaryResults, stringResult, "SvnBranch", buildInfo == null ? "Unavailable" : buildInfo.SvnBranch);
            AddValue(dictionaryResults, stringResult, "SvnLastChangedTime", buildInfo == null ? "Unavailable" : buildInfo.SvnLastChangedTime);

            AddTitle(stringResult, "GameInfo");
            AddValue(dictionaryResults, stringResult, "CurrentProcedure", GameEntry.Procedure.CurrentProcedure.GetType().ToString());
            //AddValue(dictionaryResults, stringResult, "AccountName", string.IsNullOrEmpty(GameEntry.DataCache.AccountName) ? "Unavailable" : GameEntry.DataCache.AccountName);
            //AddValue(dictionaryResults, stringResult, "ZoneId", GameEntry.DataCache.ZoneId.ToString());
            //AddValue(dictionaryResults, stringResult, "WorldId", GameEntry.DataCache.WorldId.ToString());
            //AddValue(dictionaryResults, stringResult, "SceneId", GameEntry.DataCache.SceneId.ToString());
            //AddValue(dictionaryResults, stringResult, "SceneResourceId", GameEntry.DataCache.SceneResourceId.ToString());
            //MyPlayerCharacter myPlayerCharacter = GameEntry.Entity.GetMyPlayerCharacter();
            //AddValue(dictionaryResults, stringResult, "PlayerObjId", myPlayerCharacter == null ? "Unavailable" : myPlayerCharacter.Id.ToString());
            //AddValue(dictionaryResults, stringResult, "PlayerGuid", myPlayerCharacter == null ? "Unavailable" : "0x" + myPlayerCharacter.Data.Guid.ToString("X16"));
            //AddValue(dictionaryResults, stringResult, "PlayerPosition", myPlayerCharacter == null ? "Unavailable" : myPlayerCharacter.CachedTransform.position.ToString());
            Camera mainCamera = GameEntry.Scene.MainCamera;
            AddValue(dictionaryResults, stringResult, "CameraPosition", mainCamera == null ? "Unavailable" : mainCamera.transform.position.ToString());
        }

        private void AddTitle(StringBuilder stringResult, string title)
        {
            if (stringResult != null)
            {
                stringResult.AppendLine().AppendLine(title ?? string.Empty).AppendLine("============================================================");
            }
        }

        private void AddValue(Dictionary<string, string> dictionaryResults, StringBuilder stringResult, string key, string value)
        {
            if (dictionaryResults != null)
            {
                dictionaryResults.Add(key, value);
            }

            if (stringResult != null)
            {
                stringResult.Append(key).Append(":").Append(value).AppendLine();
            }
        }
        private void Start()
        {
            m_DeviceInfo = new DeviceInfo();
            m_CpuInfo = new CpuInfo();
            m_MemoryInfo = new MemoryInfo();
            m_ScreenInfo = new ScreenInfo();
            m_SoftwareInfo = new SoftwareInfo();
        }
    }
}

