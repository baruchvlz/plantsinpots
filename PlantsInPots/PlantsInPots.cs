// PlantsInPots
// a Valheim mod skeleton using Jötunn
// 
// File:    PlantsInPots.cs
// Project: PlantsInPots

using BepInEx;
using UnityEngine;
using BepInEx.Configuration;
using Jotunn.Utils;
using HarmonyLib;

namespace PlantsInPots
{
  [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
  [BepInDependency(Jotunn.Main.ModGuid)]
  //[NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
  internal class PlantsInPots : BaseUnityPlugin
  {
    public const string PluginGUID = "com.sveit.PlantsInPots";
    public const string PluginName = "PlantsInPots";
    public const string PluginVersion = "0.0.1";
    private Harmony harmony = new Harmony(PluginGUID);

    private void Awake()
    {
      // Do all your init stuff here
      // Acceptable value ranges can be defined to allow configuration via a slider in the BepInEx ConfigurationManager: https://github.com/BepInEx/BepInEx.ConfigurationManager
      // Config.Bind<int>("Main Section", "Example configuration integer", 1, new ConfigDescription("This is an example config, using a range limitation for ConfigurationManager", new AcceptableValueRange<int>(0, 100)));

      // Jotunn comes with its own Logger class to provide a consistent Log style for all mods using it
      Jotunn.Logger.LogInfo("PlantsInPots Loaded.");
      harmony.PatchAll();
    }

    private void OnDestroy()
    {
      harmony.UnpatchAll();
    }

    [HarmonyPatch(typeof(Character), nameof(Character.Jump))]
    class CharacterJumpPatch
    {
      static void Postfix(ref float ___m_jumpForce)
      {
        ___m_jumpForce += 10;
      }
    }

#if DEBUG
    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.F6))
      { // Set a breakpoint here to break on F6 key press
        
      }
    }
#endif
  }
}