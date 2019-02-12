using GameFramework;
using UnityEngine;

namespace Game
{
    public static class AssetUtility
    {
        public static string GetConfigAsset(string assetName)
        {
            return string.Format("Assets/GameMain/Configs/{0}.txt", assetName);
        }

        public static string GetDataTableAsset(string assetName)
        {
            return string.Format("Assets/GameMain/DataTables/{0}.txt", assetName);
        }

        public static string GetDictionaryAsset(string assetName)
        {
            return string.Format("Assets/GameMain/Localization/{0}/Dictionaries/{1}.xml", GameEntry.Localization.Language.ToString(), assetName);
        }

        public static string GetLuaScriptAsset(string assetName)
        {
            if (GameEntry.Base.EditorResourceMode)
            {
                return Utility.Path.GetCombinePath(Application.dataPath, "GameMain/LuaScripts", assetName + ".lua");
            }
            else
            {
                return string.Format("Assets/GameMain/LuaScripts/{0}.lua.bytes", assetName);
            }
        }

        public static string GetShaderAsset(string assetName)
        {
            return string.Format("Assets/GameMain/{0}.shader", assetName);
        }

        public static string GetFontAsset(string assetName, bool isLocalization)
        {
            if (isLocalization)
            {
                return string.Format("Assets/GameMain/Localization/{0}/Fonts/{1}.ttf", GameEntry.Localization.Language.ToString(), assetName);
            }
            else
            {
                return string.Format("Assets/GameMain/Fonts/{0}.ttf", assetName);
            }
        }

        public static string GetSceneAsset(string assetName)
        {
            return string.Format("Assets/GameMain/Scenes/{0}.unity", assetName);
        }

        public static string GetSceneColliderAsset(string assetName)
        {
            return string.Format("Assets/GameMain/Scenes/{0}.prefab", assetName);
        }

        public static string GetSceneZoneAsset(string assetName)
        {
            return string.Format("Assets/GameMain/Scenes/{0}.bytes", assetName);
        }

        public static string GetSceneRegionAsset(string assetName)
        {
            return string.Format("Assets/GameMain/Scenes/{0}.bytes", assetName);
        }

        public static string GetSceneHeightMapAsset(string assetName)
        {
            return string.Format("Assets/GameMain/Scenes/{0}.bytes", assetName);
        }

        public static string GetServerNavMapAsset(string assetName)
        {
            return string.Format("Assets/GameMain/Scenes/{0}.bytes", assetName);
        }

        public static string GetFlyZoneAsset(string assetName)
        {
            return string.Format("Assets/GameMain/Scenes/{0}.bytes", assetName);
        }

        public static string GetMusicAsset(string assetName, bool isLocalization)
        {
            if (isLocalization)
            {
                return string.Format("Assets/GameMain/Localization/{0}/Music/{1}.mp3", GameEntry.Localization.Language.ToString(), assetName);
            }
            else
            {
                return string.Format("Assets/GameMain/Music/{0}.mp3", assetName);
            }
        }

        public static string GetSoundAsset(string assetName, bool isLocalization)
        {
            if (isLocalization)
            {
                return string.Format("Assets/GameMain/Localization/{0}/Sounds/{1}.wav", GameEntry.Localization.Language.ToString(), assetName);
            }
            else
            {
                return string.Format("Assets/GameMain/Sounds/{0}.wav", assetName);
            }
        }

        public static string GetMovieAsset(string assetName, bool isLocalization)
        {
            if (isLocalization)
            {
                return string.Format("Assets/GameMain/Localization/{0}/Movies/{1}.mp4", GameEntry.Localization.Language.ToString(), assetName);
            }
            else
            {
                return string.Format("Assets/GameMain/Movies/{0}.mp4", assetName);
            }
        }

        public static string GetBaseActorAsset()
        {
            return string.Format("Assets/GameMain/Entities/Characters/BaseActor.prefab");
        }

        public static string GetCharacterAsset(string assetName)
        {
            return string.Format("Assets/GameMain/Entities/Characters/{0}.prefab", assetName);
        }

        public static string GetEffectAsset(string assetName, bool isLocalization)
        {
            if (isLocalization)
            {
                return string.Format("Assets/GameMain/Localization/{0}/Entities/Effects/{1}.prefab", GameEntry.Localization.Language.ToString(), assetName);
            }
            else
            {
                return string.Format("Assets/GameMain/Entities/Effects/{0}.prefab", assetName);
            }
        }

        public static string GetCharacterTimeline(string assetName)
        {
            return string.Format("Assets/GameMain/Timelines/Characters/{0}.playable", assetName);
        }

        public static string GetStoryTimeline(string assetName)
        {
            return string.Format("Assets/GameMain/Timelines/Stories/{0}.playable", assetName);
        }

        public static string GetUIFormAsset(string assetName)
        {
            return string.Format("Assets/GameMain/UI/Forms/{0}.prefab", assetName);
        }

        public static string GetUIItemAsset(string assetName)
        {
            return string.Format("Assets/GameMain/UI/Items/{0}.prefab", assetName);
        }

        public static string GetUISoundAsset(string assetName, bool isLocalization)
        {
            if (isLocalization)
            {
                return string.Format("Assets/GameMain/Localization/{0}/Sounds/UI/{1}.wav", GameEntry.Localization.Language.ToString(), assetName);
            }
            else
            {
                return string.Format("Assets/GameMain/Sounds/UI/{0}.wav", assetName);
            }
        }

        public static string GetAtlasAsset(string assetName, bool isLocalization)
        {
            if (isLocalization)
            {
                return string.Format("Assets/GameMain/Localization/{0}/UI/Atlases/{1}.prefab", GameEntry.Localization.Language.ToString(), assetName);
            }
            else
            {
                return string.Format("Assets/GameMain/UI/Atlases/{0}.prefab", assetName);
            }
        }

        public static string GetTextureAsset(string assetName, bool isLocalization)
        {
            if (isLocalization)
            {
                return string.Format("Assets/GameMain/Localization/{0}/UI/Textures/{1}.png", GameEntry.Localization.Language.ToString(), assetName);
            }
            else
            {
                return string.Format("Assets/GameMain/UI/Textures/{0}.png", assetName);
            }
        }

        public static string GetIndicatorAsset(string assetName)
        {
            return string.Format("Assets/GameMain/Models/Others/Indicator/{0}.prefab", assetName);
        }

        public static string GetDropItemAsset()
        {
            return string.Format("Assets/GameMain/Entities/Others/DropItem.prefab");
        }

        public static string GetAvatarConfigAsset()
        {
            return "Assets/GameMain/DataTables/TD_config.json";
        }
    }
}
