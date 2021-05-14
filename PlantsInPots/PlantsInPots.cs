// PlantsInPots
// 
// File:    PlantsInPots.cs
// Project: PlantsInPots

using BepInEx;
using UnityEngine;
using PlantsInPots.Shared;
using PlantsInPots.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Configs;
using System.Collections.Generic;

namespace PlantsInPots
{
  [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
  [BepInDependency(Jotunn.Main.ModGuid)]
  internal class PlantsInPots : BaseUnityPlugin
  {
    public const string PluginGUID = "gundmek.PlantsInPots";
    public const string PluginName = "PlantsInPots";
    public const string PluginVersion = "0.0.1";

    private AssetBundle PiPBundle { get; set; }

    private void Awake()
    {
      LoadBundle();
      AddPotRecipes();
      AddPlantPieces();
    }

    private void LoadBundle()
    {
      PiPBundle = PiPUtils.GetBundleFromResources();
    }

    private void AddPotRecipes()
    {
      foreach (KeyValuePair<string, ItemConfig> kvp in PotsConfigs.Configs)
      {
        GameObject PotPrefab = PiPBundle.LoadAsset<GameObject>(PiPUtils.GetAssetPrefabPath(kvp.Key));
        CustomItem PotItem = new CustomItem(PotPrefab, fixReference: true, kvp.Value);

        ItemManager.Instance.AddItem(PotItem);
      }
    }

    private void AddPlantPieces()
    {
      foreach (string plant in PlantsConfigs.PlantList)
      {
        GameObject PlantPrefab = PiPBundle.LoadAsset<GameObject>(PiPUtils.GetAssetPrefabPath(plant));
        CustomPiece PlantPiece = new CustomPiece(PlantPrefab, "Hammer", fixReference: true);

        PieceManager.Instance.AddPiece(PlantPiece);
      }
    }

    private void HandleError()
    {

    }
  }
}