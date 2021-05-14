using System.Collections.Generic;
using Jotunn.Configs;
using PlantsInPots.Shared;

namespace PlantsInPots.Configs
{
  public static class PotsConfigs
  {

    private static string SmallPot { get { return $"{Constants.ModName}_SmallPot"; } }
    private static string NormalPot { get { return $"{Constants.ModName}_NormalPot"; } }
    // private static string LargePot { get { return $"{Constants.ModName}_LargePot"; } }
    private static readonly List<string> SizeVariants = new List<string> { "Small", "Normal", "Large" };

    public static Dictionary<string, ItemConfig> Configs
    {
      get
      {
        Dictionary<string, ItemConfig> dic = new Dictionary<string, ItemConfig>()
        {
          [SmallPot] = new ItemConfig
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
          },
          [NormalPot] = new ItemConfig
          {
            Amount = 1,
            CraftingStation = "piece_workbench",
            Requirements = new[]
            {
              new RequirementConfig
              {
                Item = "RoundLog",
                Amount = 2
              },
              new RequirementConfig
              {
                Item = "Wood",
                Amount = 4
              }
            }
          },
          /**
          [LargePot] = new ItemConfig
          {
            Amount = 1,
            CraftingStation = "piece_workbench",
            Requirements = new[]
            {
              new RequirementConfig
              {
                Item = "FineWood",
                Amount = 2
              },
              new RequirementConfig
              {
                Item = "RoundLog",
                Amount = 2
              },
              new RequirementConfig
              {
                Item = "Wood",
                Amount = 4
              }
            }
          }
          */
        };

        return dic;
      }
    }
    public static ItemConfig GetConfig(string potName) => Configs.ContainsKey(potName) ? Configs[potName] : null;
  }
}
