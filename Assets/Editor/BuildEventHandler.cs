using GameFramework;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityGameFramework.Editor.AssetBundleTools;

namespace Game.Editor
{
    public sealed class BuildEventHandler : IBuildEventHandler
    {
        private static readonly IDictionary<string, string> s_LuaScriptNames = new Dictionary<string, string>();
        private static Platform? m_CopiedPlatform = null;

        public bool ContinueOnFailure
        {
            get
            {
                return false;
            }
        }

        public void PreProcessBuildAll(string productName, string companyName, string gameIdentifier,
            string applicableGameVersion, int internalResourceVersion, string unityVersion, BuildAssetBundleOptions buildOptions, bool zip,
            string outputDirectory, string workingPath, string outputPackagePath, string outputFullPath, string outputPackedPath, string buildReportPath)
        {
            m_CopiedPlatform = null;
            CleanStreamingAssets();
            RenameLuaScripts();
        }

        public void PostProcessBuildAll(string productName, string companyName, string gameIdentifier,
            string applicableGameVersion, int internalResourceVersion, string unityVersion, BuildAssetBundleOptions buildOptions, bool zip,
            string outputDirectory, string workingPath, string outputPackagePath, string outputFullPath, string outputPackedPath, string buildReportPath)
        {
            RevertRenameLuaScripts();
        }

        public void PreprocessPlatform(Platform platform, string workingPath, string outputPackagePath, string outputFullPath, string outputPackedPath)
        {

        }

        public void PostprocessPlatform(Platform platform, string workingPath, string outputPackagePath, string outputFullPath, string outputPackedPath,bool isSuccess)
        {
            if (isSuccess)
            {
                CopyToStreamingAssets(platform, outputPackagePath);
            }
        }

        private static void CleanStreamingAssets()
        {
            string streamingAssetsPath = Utility.Path.GetCombinePath(Application.dataPath, "StreamingAssets");
            string[] fileNames = Directory.GetFiles(streamingAssetsPath, "*", SearchOption.AllDirectories);
            foreach (string fileName in fileNames)
            {
                File.Delete(fileName);
            }

            string[] directoryNames = Directory.GetDirectories(streamingAssetsPath, "*", SearchOption.TopDirectoryOnly);
            foreach (string directoryName in directoryNames)
            {
                Utility.Path.RemoveEmptyDirectory(directoryName);
            }
        }

        private static void CopyToStreamingAssets(Platform platform, string assetPath)
        {
            if (m_CopiedPlatform.HasValue)
            {
                return;
            }

            m_CopiedPlatform = platform;

            string streamingAssetsPath = Utility.Path.GetCombinePath(Application.dataPath, "StreamingAssets");
            string[] fileNames = Directory.GetFiles(assetPath, "*", SearchOption.AllDirectories);
            foreach (string fileName in fileNames)
            {
                string destFileName = Utility.Path.GetCombinePath(streamingAssetsPath, fileName.Substring(assetPath.Length));
                FileInfo destFileInfo = new FileInfo(destFileName);
                if (!destFileInfo.Directory.Exists)
                {
                    destFileInfo.Directory.Create();
                }

                File.Copy(fileName, destFileName);
            }
        }

        private void RenameLuaScripts()
        {
            s_LuaScriptNames.Clear();

            var luaScriptAssetNames = AssetDatabase.FindAssets("l:LuaScript").ToList().ConvertAll(guid => AssetDatabase.GUIDToAssetPath(guid));
            foreach (string luaScriptAssetName in luaScriptAssetNames)
            {
                string luaScriptAssetMetaName = luaScriptAssetName + ".meta";
                string renamedLuaScriptAssetName = luaScriptAssetName + ".bytes";
                string renamedLuaScriptAssetMetaName = renamedLuaScriptAssetName + ".meta";

                File.Move(luaScriptAssetName, renamedLuaScriptAssetName);
                s_LuaScriptNames.Add(luaScriptAssetName, renamedLuaScriptAssetName);

                File.Move(luaScriptAssetMetaName, renamedLuaScriptAssetMetaName);
                s_LuaScriptNames.Add(luaScriptAssetMetaName, renamedLuaScriptAssetMetaName);
            }

            AssetDatabase.Refresh();
        }

        private void RevertRenameLuaScripts()
        {
            foreach (var luaScriptNames in s_LuaScriptNames)
            {
                File.Move(luaScriptNames.Value, luaScriptNames.Key);
            }

            s_LuaScriptNames.Clear();
            AssetDatabase.Refresh();
        }

        public void PreprocessAllPlatforms(string productName, string companyName, string gameIdentifier, string applicableGameVersion, int internalResourceVersion, string unityVersion, BuildAssetBundleOptions buildOptions, bool zip, string outputDirectory, string workingPath, string outputPackagePath, string outputFullPath, string outputPackedPath, string buildReportPath)
        {
            m_CopiedPlatform = null;
            CleanStreamingAssets();
            RenameLuaScripts();
        }

        public void PostprocessAllPlatforms(string productName, string companyName, string gameIdentifier, string applicableGameVersion, int internalResourceVersion, string unityVersion, BuildAssetBundleOptions buildOptions, bool zip, string outputDirectory, string workingPath, string outputPackagePath, string outputFullPath, string outputPackedPath, string buildReportPath)
        {
            RevertRenameLuaScripts();
        }
        //private string GetPlatformName()
        //{
        //    string platformName = "Windows";
        //    SelectBuildPlatform.LoadBuildSettingXml();
        //    var platform = SelectBuildPlatform.GetCurrentSelectSetting().Platforms;
        //    switch (platform)
        //    {
        //        case Platform.Android:
        //            platformName = "Android";
        //            break;
        //        case Platform.IOS:
        //            platformName = "iOS";
        //            break;
        //        case Platform.MacOS:
        //            platformName = "Mac";
        //            break;
        //    }

        //    return platformName;
        //}
        private string GetLanguageName()
        {
            string languageName = "Chinese";
            return languageName;
        }
    }
}
