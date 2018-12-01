using GameFramework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Game.Editor
{
    internal sealed class LabelUtility
    {
        public static bool HasLabel(string assetPath, string label)
        {
            Object asset = AssetDatabase.LoadMainAssetAtPath(assetPath);
            if (asset != null)
            {
                return AssetDatabase.GetLabels(asset).Contains(label);
            }

            return false;
        }

        public static void SetLabel(string assetPath, string label)
        {
            SetLabel(assetPath, new string[] { label });
        }

        public static void SetLabel(string assetPath, string[] labels)
        {
            Object asset = AssetDatabase.LoadMainAssetAtPath(assetPath);
            if (asset != null)
            {
                HashSet<string> assetLabels = new HashSet<string>();
                foreach (string label in labels)
                {
                    assetLabels.Add(label);
                }

                AssetDatabase.SetLabels(asset, assetLabels.ToArray());
            }
        }

        public static void AddLabel(string assetPath, string label)
        {
            AddLabel(assetPath, new string[] { label });
        }

        public static void AddLabel(string assetPath, string[] labels)
        {
            Object asset = AssetDatabase.LoadMainAssetAtPath(assetPath);
            if (asset != null)
            {
                HashSet<string> assetLabels = new HashSet<string>(AssetDatabase.GetLabels(asset));
                foreach (string label in labels)
                {
                    assetLabels.Add(label);
                }

                AssetDatabase.SetLabels(asset, assetLabels.ToArray());
            }
        }

        public static void RemoveLabel(string assetPath, string label)
        {
            RemoveLabel(assetPath, new string[] { label });
        }

        public static void RemoveLabel(string assetPath, string[] labels)
        {
            Object asset = AssetDatabase.LoadMainAssetAtPath(assetPath);
            if (asset != null)
            {
                HashSet<string> assetLabels = new HashSet<string>(AssetDatabase.GetLabels(asset));
                foreach (string label in labels)
                {
                    assetLabels.Remove(label);
                }

                AssetDatabase.SetLabels(asset, assetLabels.ToArray());
            }
        }

        public static void RemoveAllLabels(string assetPath)
        {
            Object asset = AssetDatabase.LoadMainAssetAtPath(assetPath);
            if (asset != null)
            {
                AssetDatabase.SetLabels(asset, new string[] { });
            }
        }

        [MenuItem("Game Tools/资源工具/输出所有标签")]
        private static void ProcessAllAssets()
        {
            LabelController controller = new LabelController();
            string[] labels = controller.ProcessAllAssets();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Used Labels:");
            foreach (string label in labels)
            {
                stringBuilder.AppendLine(label);
            }

            if (labels.Length <= 0)
            {
                stringBuilder.AppendLine("<None>");
            }

            Debug.Log(stringBuilder.ToString());
        }

        private sealed class LabelController
        {
            public string[] ProcessAllAssets()
            {
                HashSet<string> assetNames = new HashSet<string>();
                string[] assetGuids = AssetDatabase.FindAssets(string.Empty);
                foreach (string assetGuid in assetGuids)
                {
                    string assetName = AssetDatabase.GUIDToAssetPath(assetGuid);
                    if (string.IsNullOrEmpty(assetName))
                    {
                        continue;
                    }

                    assetNames.Add(assetName);
                }

                return ProcessAssets(assetNames.OrderBy(x => x).ToArray());
            }

            public string[] ProcessAssets(string[] assetNames)
            {
                HashSet<string> labels = new HashSet<string>();
                int index = 0;
                int count = assetNames.Length;
                foreach (string assetName in assetNames)
                {
                    index++;

                    if (EditorUtility.DisplayCancelableProgressBar(
                        Utility.Text.Format("Processing Assets ({0}/{1})", index.ToString(), count.ToString()),
                        Utility.Text.Format("Processing {0} ...", assetName),
                        (float)(index - 1) / count))
                    {
                        break;
                    }

                    Object asset = AssetDatabase.LoadAssetAtPath<Object>(assetName);
                    string[] assetLabels = AssetDatabase.GetLabels(asset);
                    foreach (string assetLabel in assetLabels)
                    {
                        labels.Add(assetLabel);
                    }
                }

                EditorUtility.ClearProgressBar();
                return labels.OrderBy(x => x).ToArray();
            }
        }
    }
}
