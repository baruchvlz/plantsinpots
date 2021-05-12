using UnityEngine;
using Jotunn.Utils;
using Jotunn.Configs;
using System.Collections.Generic;

namespace PlantsInPots.Shared
{
  public static class PiPAssetUtilConstants
  {
    public static string BundleName { get { return $"{Constants.ModName.ToLower()}_assets"; } }
    public static string BundlePath { get { return $"{Application.dataPath}/Assets/{BundleName}"; } }
    public static string TestPlant { get { return $"{Constants.ModName}_Test"; } }
    public static string TestPlantTwo { get { return $"{Constants.ModName}_TestTwo"; } }
    public static string SmallPot { get { return $"{Constants.ModName}_SmallPot"; } }
  }

  public static class PiPAssetUtils
  {
    public static string GetAssetPrefabPath(string prefabName) => $"Assets/{Constants.ModName}/Bundle/{prefabName}.prefab";
    public static AssetBundle GetBundle() => AssetUtils.LoadAssetBundle(PiPAssetUtilConstants.BundlePath);
    public static AssetBundle GetBundleFromResources() => AssetUtils.LoadAssetBundleFromResources(PiPAssetUtilConstants.BundleName, typeof(PlantsInPots).Assembly);

    public static List<string> PlantList = new List<string>()
    {
      PiPAssetUtilConstants.TestPlant,
      PiPAssetUtilConstants.TestPlantTwo,
    };

    public static Dictionary<string, ItemConfig> PotDictionary = new Dictionary<string, ItemConfig>()
    {
      [PiPAssetUtilConstants.SmallPot] = new ItemConfig
      {
        Amount = 1,
        CraftingStation = "piece_workbench",
        Requirements = new[]
        {
          new RequirementConfig
          {
            Item = "Wood",
            Amount = 2
          }
        }
      }
    };
  }
}
