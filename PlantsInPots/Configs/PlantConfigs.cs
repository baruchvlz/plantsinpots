using System.Collections.Generic;
using System.Linq;
using PlantsInPots.Shared;

namespace PlantsInPots.Configs
{
  internal static class PlantsConfigs
  {
    private static readonly List<string> ColorVariants = new List<string> { "Red", "Blue", "Yellow" };

    private static List<string> GenerateColorVariants(string suffix)
    {
      List<string> VariantList = new List<string>();

      ColorVariants.ForEach(Color => VariantList.Add($"{Constants.ModName}_{Color}{suffix}"));

      return VariantList;
    }

    public static List<string> SmallPlantVariants { get { return GenerateColorVariants("Plant"); } }

    public static List<string> BouquetVariants { get { return GenerateColorVariants("Bouquet"); } }

    public static List<string> PlantList { get { return SmallPlantVariants.Concat(BouquetVariants).ToList(); } }
  }
}
