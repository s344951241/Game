using GameFramework;
using UnityEngine;
using UnityGameFramework.Editor;
using UnityGameFramework.Editor.AssetBundleTools;

namespace Game.Editor
{
    public static class GameFrameworkConfig
    {
        [BuildSettingsConfigPath]
        public static readonly string BuildSettingsConfig = Utility.Path.GetCombinePath(Application.dataPath, "GameMain/Configs/BuildSettings.xml");

        [AssetBundleBuilderConfigPath]
        public static readonly string AssetBundleBuilderConfig = Utility.Path.GetCombinePath(Application.dataPath, "GameMain/Configs/AssetBundleBuilder.xml");

        [AssetBundleEditorConfigPath]
        public static readonly string AssetBundleEditorConfig = Utility.Path.GetCombinePath(Application.dataPath, "GameMain/Configs/AssetBundleEditor.xml");

        [AssetBundleCollectionConfigPath]
        public static readonly string AssetBundleCollectionConfig = Utility.Path.GetCombinePath(Application.dataPath, "GameMain/Configs/AssetBundleCollection.xml");
    }
}
