using UnityEngine;
using System.Linq;
using System.Reflection;
using System.IO;

namespace PlantsInPots.Shared
{
  class AssetConstants
  {
    public static string BundleName { get { return $"{Constants.ModName.ToLower()}_assetbundle"; } }
    public static string AssetPath { get { return $"Assets/{Constants.ModName}"; } }
    public static string YellowPlant { get { return $"{Constants.ModName}_Yellow"; } }
    public static string ThistlePlant {  get { return $"{Constants.ModName}_Thistle"; } }
    public static string SmallPot { get { return $"{Constants.ModName}_SmallPot"; } }

  }
  class AssetUtils
  {
    public static string GetAssetPrefabPath(string prefabName) => $"{AssetConstants.AssetPath}/${prefabName}.prefab";
    public static AssetBundle GetBundle(string filename) 
    {
      Assembly execAssembly = Assembly.GetExecutingAssembly();
      string resourceName = execAssembly.GetManifestResourceNames().Single(str => str.EndsWith(filename));

      AssetBundle bundle;

      using Stream stream = execAssembly.GetManifestResourceStream(resourceName);

      bundle = AssetBundle.LoadFromStream(stream);

      return bundle;
    }
  }
}
