using GameFramework;
using Slib.Graph;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityGameFramework.Editor.AssetBundleTools;

namespace ProjectS.Editor
{
    /// <summary>
    /// 自动加载AssetBundles
    /// </summary>
    public class AssetBundleAuto
    {
        private AssetBundleEditorController m_Controller = null;
        private static string PATH = Utility.Path.GetCombinePath(Application.dataPath, "GameMain/Configs/AssetBundleCollection.xml");
        private AssetBundleLoadType LoadType = AssetBundleLoadType.LoadFromFile;

        [MenuItem("Project-S/构建工具/仅生成 AssetBundle 集合")]
        private static void Open()
        {
            //CreateEditorXml();
            if (File.Exists(PATH))
            {
                File.Delete(PATH);
            }
            AssetDatabase.Refresh();
            AssetBundleAuto auto = new AssetBundleAuto();
            auto.Init();
            auto.GraMath();
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            //LabelUtility.SetLabel(PATH.Substring(PATH.IndexOf("Assets")), "AssetBundleExclusive");
        }

        private static void CreateEditorXml()
        {
            string EditorPath = Utility.Path.GetCombinePath(Application.dataPath, "GameMain/Configs/AssetBundleEditor.xml");

            if (File.Exists(EditorPath))
            {
                File.Delete(EditorPath);
            }
            string content = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
                             "<UnityGameFramework>\n" +
                             "  <AssetBundleEditor>\n" +
                             "    <Settings>\n" +
                             "      <SourceAssetRootPath>Assets/GameMain</SourceAssetRootPath>\n" +
                             "      <SourceAssetSearchPaths>\n" +
                             "        <SourceAssetSearchPath RelativePath=\"\" />\n" +
                             "      </SourceAssetSearchPaths>\n" +
                             "      <SourceAssetUnionTypeFilter>t:Scene t:Prefab t:AudioClip t:Font t:Shader t:ShaderVariantCollection t:TextAsset t:TimelineAsset t:VideoClip t:AnimationClip t:Material t:animatorcontroller t:Texture</SourceAssetUnionTypeFilter>\n" +
                             "      <SourceAssetUnionLabelFilter>l:AssetBundleInclusive l:LuaScript l:WwiseBank</SourceAssetUnionLabelFilter>\n" +
                             "      <SourceAssetExceptTypeFilter>t:Script</SourceAssetExceptTypeFilter>\n" +
                             "      <SourceAssetExceptLabelFilter>l:AssetBundleExclusive</SourceAssetExceptLabelFilter>\n" +
                             "      <AssetSorter>Name</AssetSorter>\n" +
                             "    </Settings>\n" +
                             "  </AssetBundleEditor>\n" +
                             "</UnityGameFramework>";
            using (FileStream fs = new FileStream(EditorPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.WriteLine(content);
                sw.Close();
            }
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            //LabelUtility.SetLabel(EditorPath.Substring(EditorPath.IndexOf("Assets")), "AssetBundleExclusive");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        private void Init()
        {
            m_Controller = new AssetBundleEditorController();
            if (m_Controller.Load())
            {
                Debug.Log("Load configuration success.");
            }
            else
            {
                Debug.LogWarning("Load configuration failure.");
            }
        }

        private void AddAssetBundle(string assetBundleName, string assetBundleVariant, bool refresh, AssetBundleLoadType loadTyp = AssetBundleLoadType.LoadFromFile)
        {
            if (assetBundleVariant == string.Empty)
            {
                assetBundleVariant = null;
            }

            string assetBundleFullName = GetAssetBundleFullName(assetBundleName, assetBundleVariant);
            if (m_Controller.GetAssetBundle(assetBundleFullName, assetBundleVariant) == null)
            {
                if (m_Controller.AddAssetBundle(assetBundleName, assetBundleVariant, loadTyp, true))
                {
                    Debug.Log(Utility.Text.Format("Add AssetBundle '{0}' success.", assetBundleFullName));
                }
                else
                {
                    Debug.LogWarning(Utility.Text.Format("Add AssetBundle '{0}' failure.", assetBundleFullName));
                }
            }
        }

        private string GetAssetBundleFullName(string assetBundleName, string assetBundleVariant)
        {
            return assetBundleVariant != null ? Utility.Text.Format("{0}.{1}", assetBundleName, assetBundleVariant) : assetBundleName;
        }

        private void GraMath()
        {
            float Pcur = 0;
            float Psum = 0;
            //string[] paths = { "Assets/GameMain" };

            HashSet<SourceAsset> allSourceAssets = new HashSet<SourceAsset>(m_Controller.GetSourceAssets());

            //1独立ab shader configs DataTables luaScripts
            {

                Pcur = 0;
                Psum = 0;

                Psum = allSourceAssets.Count;
                HashSet<SourceAsset> DelAssets = new HashSet<SourceAsset>();
                foreach (SourceAsset asset in allSourceAssets)
                {
                    Pcur++;
                    EditorUtility.DisplayProgressBar("MakingCombineBundle", "Processing...", Pcur / Psum);

                    if (m_Controller.GetAsset(asset.Guid) == null)
                    {
                        string assetSting = asset.FromRootPath;
                        int dotIndex = asset.FromRootPath.IndexOf('.');
                        string assetBundleName = dotIndex > 0 ? asset.FromRootPath.Substring(0, dotIndex) : asset.FromRootPath;
                        string bundleName = assetBundleName;
                        if (assetSting.IndexOf("/Editor/") != -1)
                        {
                            if (!DelAssets.Contains(asset))
                            {
                                DelAssets.Add(asset);
                            }
                            continue;
                        }
                        if (assetSting.IndexOf("Localization/ChineseSimplified/Dictionaries") != -1)
                        {
                            bundleName = "Dictionaries";
                            LoadType = AssetBundleLoadType.LoadFromMemoryAndDecrypt;
                        }
                        else if (assetSting.IndexOf("Configs/") != -1)
                        {
                            bundleName = "Configs";
                            LoadType = AssetBundleLoadType.LoadFromMemoryAndDecrypt;
                        }
                        else if (assetSting.IndexOf("DataTables/") != -1)
                        {
                            bundleName = "DataTables";
                            LoadType = AssetBundleLoadType.LoadFromMemoryAndDecrypt;
                        }
                        else if (assetSting.IndexOf("LuaScripts/") != -1)
                        {
                            bundleName = "LuaScripts";
                            LoadType = AssetBundleLoadType.LoadFromMemoryAndDecrypt;
                        }
                        else if (assetSting.IndexOf("Shaders/") != -1 || asset.Path.EndsWith(".shader") || asset.Path.EndsWith(".cginc"))
                        {
                            bundleName = "Shaders";
                            LoadType = AssetBundleLoadType.LoadFromMemoryAndDecrypt;
                        }
                        //else if (assetSting.IndexOf("Wwise") != -1)
                        //{
                        //    ///Wwise的平台处理
                        //    bundleName = "Wwise";
                        //    string pathChild = assetSting.Substring(assetSting.IndexOf("Wwise"));
                        //    if (SelectBuildPlatform.GetCurrentSelectSetting() == null)
                        //    {
                        //        SelectBuildPlatform.LoadBuildSettingXml();
                        //        if (SelectBuildPlatform.GetCurrentSelectSetting() == null)
                        //        {
                        //            EditorUtility.ClearProgressBar();
                        //            if (EditorUtility.DisplayDialog("提示", "没有选择【Project-S/构建工具/构建平台配置选择】里的平台", "打开设置", "我自己去打开"))
                        //            {
                        //                EditorApplication.ExecuteMenuItem("Project-S/构建工具/构建平台配置选择");
                        //            }
                        //            return;
                        //        }

                        //    }
                        //    Platform plat = SelectBuildPlatform.GetCurrentSelectSetting().Platforms;
                        //    string platString = BundleSwitch.Instance.WwiseGetPlatformString(plat);
                        //    if (!pathChild.Contains(platString) && BundleSwitch.Instance.PathInSwitch(pathChild))
                        //    {
                        //        if (!DelAssets.Contains(asset))
                        //        {
                        //            DelAssets.Add(asset);
                        //        }
                        //        continue;
                        //    }
                        //}
                        else
                        {
                            continue;
                        }
                        if (!DelAssets.Contains(asset))
                        {
                            DelAssets.Add(asset);
                        }
                        AddAssetBundle(bundleName, null, false, LoadType);
                        LoadType = AssetBundleLoadType.LoadFromFile;
                        UnityGameFramework.Editor.AssetBundleTools.AssetBundle assetBundle = m_Controller.GetAssetBundle(bundleName, null);
                        if (assetBundle == null)
                        {
                            continue;
                        }
                        m_Controller.AssignAsset(asset.Guid, assetBundle.Name, assetBundle.Variant);

                    }

                }
                foreach (SourceAsset item in DelAssets)
                {
                    if (allSourceAssets.Contains(item))
                    {
                        allSourceAssets.Remove(item);
                    }
                }
                EditorUtility.ClearProgressBar();

            }
            HashSet<string> SinglePaths = new HashSet<string>();
            HashSet<string> CheckPaths = new HashSet<string>();
            //2 进行有向图检测资源
            {
                Psum = 0;
                Pcur = 0;
                foreach (SourceAsset item in allSourceAssets)
                {
                    SinglePaths.Add(item.Path);
                    CheckPaths.Add(item.Path);
                }

                List<List<string>> pathss = new List<List<string>>();
                Psum = allSourceAssets.Count;
                //TODO合并资源的算法
                HashSet<string> checkNameHas = new HashSet<string>();

                foreach (SourceAsset sourceAsset in allSourceAssets)
                {
                    Pcur++;
                    EditorUtility.DisplayProgressBar("MakingMapAssetbundle", "Processing...", Pcur / Psum);
                    string path = sourceAsset.Path;
                    List<string> depend_list = new List<string>();
                    string[] files = AssetDatabase.GetDependencies(path, false);
                    if (files.Length > 0)
                    {
                        checkNameHas.Clear();
                        depend_list.Add(path);
                        checkNameHas.Add((Path.GetFileName(path)).ToLower());
                        if (SinglePaths.Contains(path))
                        {

                            SinglePaths.Remove(path);
                        }
                        for (int i = 0; i < files.Length; i++)
                        {
                            string file = files[i];
                            if (!CheckPaths.Contains(file))
                            {
                                continue;
                            }

                            if (!file.Equals(path) && !file.EndsWith(".cs") && file.StartsWith("Assets/GameMain"))
                            {
                                string name = Path.GetFileName(file).ToLower();
                                if (checkNameHas.Contains(name))
                                {
                                    Debug.LogWarning("存在不符合打包的相同资源名:" + name);
                                }
                                else
                                {
                                    checkNameHas.Add(name);
                                    depend_list.Add(file);
                                    if (SinglePaths.Contains(file))
                                    {
                                        SinglePaths.Remove(file);
                                    }
                                }

                            }
                        }
                        pathss.Add(depend_list);
                    }
                }
                SymbolDiGraph sdg = new SymbolDiGraph(pathss);
                if (new DirectedCycle(sdg.G()).hasCycle())
                {
                    Debug.LogError("资源依赖存在问题");
                    //EditorUtility.ClearProgressBar();
                    //return;
                }
                List<int> listOrder = new Topolgical(sdg.G()).order();

                Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
                for (int i = 0; i < listOrder.Count; i++)
                {
                    int num = listOrder[i];
                    int result = -1;
                    int sum = sdg.G().inDegree(num, out result);
                    if (sum > 1)
                    {
                        if (dict.ContainsKey(num))
                        {
                            dict[num].Add(num);
                        }
                        else
                        {
                            List<int> list = new List<int>
                            {
                                num
                            };
                            dict.Add(num, list);
                        }
                        EditorUtility.DisplayProgressBar("SetTextures", "Processing...", 1);
                        //string path = graph.name(num);

                        //if (path.EndsWith(".png") || path.EndsWith(".tga") || path.EndsWith(".TGA") || path.EndsWith(".PNG"))
                        //{
                        //    TextureImporter ti = TextureImporter.GetAtPath(path) as TextureImporter;
                        //    if (ti != null && ti.isReadable == false)
                        //    {
                        //        ti.isReadable = true;
                        //        AssetDatabase.ImportAsset(path);
                        //    }
                        //}
                    }
                    else if (sum == 0)
                    {
                        if (dict.ContainsKey(num))
                        {
                            dict[num].Add(num);
                        }
                        else
                        {
                            List<int> list = new List<int>
                            {
                                num
                            };
                            dict.Add(num, list);
                        }
                        EditorUtility.DisplayProgressBar("SetTextures", "Processing...", 1);
                        //string path = graph.name(num);
                        //if (path.EndsWith(".png") || path.EndsWith(".tga") || path.EndsWith(".TGA") || path.EndsWith(".PNG"))
                        //{
                        //    TextureImporter ti = (TextureImporter)TextureImporter.GetAtPath(path);
                        //    if (ti != null && ti.isReadable == false)
                        //    {
                        //        ti.isReadable = true;
                        //        AssetDatabase.ImportAsset(path);
                        //    }
                        //}
                        //TODO合并
                    }
                    else if (sum == 1)
                    {
                        int parent = getOneInDegreeParent(sdg.G(), num);
                        if (dict.ContainsKey(parent))
                        {
                            dict[parent].Add(num);
                        }
                    }
                }
                Psum = dict.Count;
                Pcur = 0;
                foreach (KeyValuePair<int, List<int>> item in dict)
                {
                    Pcur++;
                    EditorUtility.DisplayProgressBar("SetAssetbundle", "Processing...", Pcur / Psum);
                    string path = sdg.name(item.Key);
                    int dotIndex = path.IndexOf('.');
                    int len = "Assets/GameMain/".Length;
                    string bundleName = dotIndex > 0 ? path.Substring(len, dotIndex - len) : path;
                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        if (path.EndsWith(".FBX"))
                        {
                            bundleName = bundleName.Replace("@", "");
                        }
                        else if (path.EndsWith(".unity"))
                        {
                            if (i > 0)
                            {
                                if (!bundleName.EndsWith("_Data"))
                                {
                                    bundleName = bundleName + "_Data";
                                }
                            }
                            else
                            {
                                if (!bundleName.EndsWith("_Scene"))
                                {
                                    bundleName = bundleName + "_Scene";
                                }
                            }
                        }
                        //else
                        //{
                        //    if (!bundleName.EndsWith("_AB"))
                        //        bundleName = bundleName + "_AB";
                        //}

                        AddAssetBundle(bundleName, null, false);
                        UnityGameFramework.Editor.AssetBundleTools.AssetBundle assetBundle = m_Controller.GetAssetBundle(bundleName, null);
                        if (assetBundle == null)
                        {
                            continue;
                        }
                        string name = sdg.name(item.Value[i]);
                        bool flag =m_Controller.AssignAsset(AssetDatabase.AssetPathToGUID(name), assetBundle.Name, assetBundle.Variant);
                        if (flag == false)
                        {
                            if (!SinglePaths.Contains(name))
                            {
                                SinglePaths.Add(name);
                            }
                            Debug.LogWarning("由于相同名字出现在ab中需要改名：" + name);
                        }
                    }
                }

                EditorUtility.ClearProgressBar();
            }

            //3 无依赖的独立资源进行打包
            {
                Psum = 0;
                Pcur = 0;
                EditorUtility.DisplayProgressBar("Save", "Processing...", Pcur / Psum);
                Psum = SinglePaths.Count;
                foreach (string path in SinglePaths)
                {
                    Pcur++;
                    EditorUtility.DisplayProgressBar("MakingSingleAssetbudle", "Processing...", Pcur / Psum);
                    int index = path.LastIndexOf('/');
                    int len = "Assets/GameMain/".Length;
                    string newPath = path.Substring(len, index - len);
                    string bundleName = newPath;
                    //int dotIndex = path.IndexOf('.');
                    //int len = "Assets/GameMain/".Length;
                    //string bundleName = dotIndex > 0 ? path.Substring(len, dotIndex - len) : path;
                    if (path.EndsWith(".unity"))
                    {
                        bundleName += "_Scene";
                    }
                    else
                    {
                        if (path.EndsWith(".FBX"))
                        {
                            bundleName = bundleName.Replace("@", "");
                        }
                        bundleName += "_Data";
                    }
                    AddAssetBundle(bundleName, null, false);
                    UnityGameFramework.Editor.AssetBundleTools.AssetBundle assetBundle = m_Controller.GetAssetBundle(bundleName, null);
                    if (assetBundle == null)
                    {
                        continue;
                    }
                    m_Controller.AssignAsset(AssetDatabase.AssetPathToGUID(path), assetBundle.Name, assetBundle.Variant);
                }
                EditorUtility.ClearProgressBar();
            }

            if (m_Controller.Save())
            {
                Debug.Log("Save configuration success.");
            }
            else
            {
                Debug.LogWarning("Save configuration failure.");
            }
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        private int getOneInDegreeParent(DiGraph graph, int num)
        {
            int result = -1;
            int value = -1;

            while (graph.inDegree(num, out result) == 1)
            {
                num = result;
                value = num;
            }
            return value;
        }
    }
}
