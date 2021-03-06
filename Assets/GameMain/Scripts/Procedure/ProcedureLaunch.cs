﻿using GameFramework;
using GameFramework.Localization;
using GameFramework.Procedure;
using System;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace Game
{
    public class ProcedureLaunch : ProcedureBase
    {
        public override bool UseNativeDialog
        {
            get
            {
                return true;
            }
        }

        protected internal override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);

#if UNITY_EDITOR && !UNITY_2018_1
            UnityEditor.EditorApplication.isPlaying = false;
            UnityEditor.EditorUtility.DisplayDialog("提示信息", "请使用 Unity 2018.1.2f1 版本运行工程。", "知道了");
#endif
            GameEntry.Event.Fire(this, ReferencePool.Acquire<CommonEventArgs>().Fill("Enter ProcedureLaunch..."));
            // 构建信息：发布版本时，把一些数据以 Json 的格式写入 Assets/GameMain/Configs/BuildInfo.txt，供游戏逻辑读取。
            GameEntry.BuiltinData.InitBuildInfo();

            // 语言配置：设置当前使用的语言，如果不设置，则默认使用操作系统语言。
            InitLanguageSettings();

            // 变体配置：根据使用的语言，通知底层加载对应的资源变体。
            InitCurrentVariant();

            // 画质配置：设置即将使用的画质选项。
            InitQualitySettings();

            // 声音配置：根据用户配置数据，设置即将使用的声音选项。
            InitSoundSettings();

            // 默认字典：加载默认字典文件。此字典文件记录了资源更新前使用的各种语言的字符串，会随 App 一起发布，故不可更新。
            //GameEntry.BuiltinData.InitDefaultDictionary();

            ////初始化 A*Path
            ////InitAstarPath();

            int maxScreenHeight = 720;
            if (GameEntry.SystemInfo.Screen.ScreenHeight > maxScreenHeight)
            {
                Screen.SetResolution((int)((float)GameEntry.SystemInfo.Screen.ScreenWidth / GameEntry.SystemInfo.Screen.ScreenHeight * maxScreenHeight + 0.5f), maxScreenHeight, true);
            }
#if UNITY_IOS
            if (UnityEngine.iOS.Device.generation == UnityEngine.iOS.DeviceGeneration.iPhone8
                || UnityEngine.iOS.Device.generation == UnityEngine.iOS.DeviceGeneration.iPhone8Plus
                || UnityEngine.iOS.Device.generation == UnityEngine.iOS.DeviceGeneration.iPhoneX)
            {
                QualitySettings.shadows = ShadowQuality.All;
                QualitySettings.shadowmaskMode = ShadowmaskMode.DistanceShadowmask;
                QualitySettings.shadowProjection = ShadowProjection.CloseFit;
            }
#endif
        }

        protected internal override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

            ChangeState<ProcedureSplash>(procedureOwner);
        }

        private void InitLanguageSettings()
        {
            if (GameEntry.Base.EditorResourceMode && GameEntry.Base.EditorLanguage != Language.Unspecified)
            {
                // 编辑器资源模式直接使用 Inspector 上设置的语言
                return;
            }

            Language language = GameEntry.Localization.Language;
            string languageString = GameEntry.Setting.GetString(Constant.Setting.Language);
            if (!string.IsNullOrEmpty(languageString))
            {
                try
                {
                    language = (Language)Enum.Parse(typeof(Language), languageString);
                }
                catch
                {

                }
            }

            if (language != Language.English
                && language != Language.ChineseSimplified
                && language != Language.ChineseTraditional
                && language != Language.Korean)
            {
                // 若是暂不支持的语言，则使用英语
                language = Language.English;

                GameEntry.Setting.SetString(Constant.Setting.Language, language.ToString());
                GameEntry.Setting.Save();
            }

            GameEntry.Localization.Language = language;

            Log.Info("Init language settings complete, current language is '{0}'.", language.ToString());
        }

        private void InitCurrentVariant()
        {
            if (GameEntry.Base.EditorResourceMode)
            {
                // 编辑器资源模式不使用 AssetBundle，也就没有变体了
                return;
            }

            string currentVariant = null;
            switch (GameEntry.Localization.Language)
            {
                case Language.English:
                    currentVariant = "en-us";
                    break;
                case Language.ChineseSimplified:
                    currentVariant = "zh-cn";
                    break;
                case Language.ChineseTraditional:
                    currentVariant = "zh-tw";
                    break;
                case Language.Korean:
                    currentVariant = "ko-kr";
                    break;
                default:
                    currentVariant = "zh-cn";
                    break;
            }

            GameEntry.Resource.SetCurrentVariant(currentVariant);

            Log.Info("Init current variant complete.");
        }

        private void InitQualitySettings()
        {
            if (GameEntry.Quality.SettingQualityLevel.HasValue)
            {
                GameEntry.Quality.SetQualityLevel(GameEntry.Quality.SettingQualityLevel.Value);
            }
            else
            {
                // TODO: 根据机型判断
                GameEntry.Quality.SetQualityLevel(QualityLevelType.Ultra, true);
            }

            Log.Info("Init quality settings complete.");
        }

        private void InitSoundSettings()
        {
            //GameEntry.Sound.Mute("Music", GameEntry.Setting.GetBool(Constant.Setting.MusicMuted, false));
            //GameEntry.Sound.SetVolume("Music", GameEntry.Setting.GetFloat(Constant.Setting.MusicVolume, 1f));
            //GameEntry.Sound.Mute("Sound", GameEntry.Setting.GetBool(Constant.Setting.SoundMuted, false));
            //GameEntry.Sound.SetVolume("Sound", GameEntry.Setting.GetFloat(Constant.Setting.SoundVolume, 1f));
            //GameEntry.Sound.Mute("UISound", GameEntry.Setting.GetBool(Constant.Setting.UISoundMuted, false));
            //GameEntry.Sound.SetVolume("UISound", GameEntry.Setting.GetFloat(Constant.Setting.UISoundVolume, 1f));

            Log.Info("Init sound settings complete.");
        }

        //private void InitAstarPath()
        //{
        //    AstarPath.active.AwakeAstarPath();
        //}
    }
}