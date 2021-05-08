﻿// PlantsInPots
// a Valheim mod skeleton using Jötunn
// 
// File:    PlantsInPots.cs
// Project: PlantsInPots

using BepInEx;
using UnityEngine;
using HarmonyLib;
using PlantsInPots.Shared;

namespace PlantsInPots
{
  [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
  [BepInDependency(Jotunn.Main.ModGuid)]
  internal class PlantsInPots : BaseUnityPlugin
  {
    public const string PluginGUID = "gundmek.PlantsInPots";
    public const string PluginName = "PlantsInPots";
    public const string PluginVersion = "0.0.1";
    private readonly Harmony harmony = new Harmony(PluginGUID);

    private void Awake()
    {
      Jotunn.Logger.LogInfo("PlantsInPots Loaded.");
      harmony.PatchAll();
      RegisterPrefabs();
    }

    private void OnDestroy()
    {
      harmony.UnpatchAll();
    }

    private void RegisterPrefabs()
    {
      // get prefab for pot? idk...s

      Jotunn.Logger.LogDebug($" Accessing Bundle Name ==> {AssetConstants.BundleName}");
      AssetBundle bundle = AssetUtils.GetBundle(AssetConstants.BundleName);
      /**
       * GameObject[] assets = bundle.LoadAllAssets<GameObject>();

      foreach (GameObject asset in assets)
      {
        Jotunn.Logger.LogMessage($"Load asset => {asset.name}");
      }
      **/

      Jotunn.Logger.LogDebug(bundle);
    }

    private void AddRecipes()
    {

    }

#if DEBUG
    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.F4))
      { // Set a breakpoint here to break on F6 key press
        
      }
    }
#endif
  }
}