namespace Game
{
    public static partial class Constant
    {
        /// <summary>
        /// 资源优先级。
        /// </summary>
        public static class AssetPriority
        {
            public const int ConfigAsset = 100;
            public const int DataTableAsset = 100;
            public const int DictionaryAsset = 100;
            public const int LuaScriptAsset = 100;
            public const int ShaderAsset = 100;

            public const int EntityAsset = 80;
            public const int AnimationAsset = 80;
            public const int TimelineAsset = 80;

            public const int UIFormAsset = 50;
            public const int AtlasAsset = 50;
            public const int TextureAsset = 50;
            public const int FontAsset = 50;

            public const int PrefabAsset = 30;
            public const int SoundAsset = 30;
            public const int UISoundAsset = 30;

            public const int MusicAsset = 20;
            public const int MovieAsset = 20;

            public const int SceneAsset = 0;
            public const int SceneInfoAsset = 0;
        }
    }
}
