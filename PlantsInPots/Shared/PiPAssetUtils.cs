using UnityEngine;
using Jotunn.Utils;

namespace PlantsInPots.Shared
{
  public static class PiPUtils
  {
    public static string GetAssetPrefabPath(string prefabName) => $"Assets/{Constants.ModName}/Bundle/{prefabName}.prefab";
    public static AssetBundle GetBundle() => AssetUtils.LoadAssetBundle(Constants.BundlePath);
    public static AssetBundle GetBundleFromResources() => AssetUtils.LoadAssetBundleFromResources(Constants.BundleName, typeof(PlantsInPots).Assembly);
  }
}
