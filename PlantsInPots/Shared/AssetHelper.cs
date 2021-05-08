using UnityEngine;
using System.Linq;
using System.Reflection;
using System.IO;

namespace PlantsInPots.Shared
{
  class AssetNames
  {
    private readonly static string Prefix = "PlantsInPots";
    public static string YellowPlant { get { return $"{Prefix}_Yellow"; } }
    public static string ThistlePlant {  get { return $"{Prefix}_Thistle"; } }
    public static string SmallPot { get { return $"{Prefix}_SmallPot"; } }
  }
  class AssetHelper
  {
    public static AssetBundle GetBundle(string filename)
    {
      Assembly execAssembly = Assembly.GetExecutingAssembly();
      string resourceName = execAssembly.GetManifestResourceNames().Single(str => str.EndsWith(filename));

      AssetBundle bundle;

      using (Stream stream = execAssembly.GetManifestResourceStream(resourceName))
      {
        bundle = AssetBundle.LoadFromStream(stream);
      }

      return bundle;
    }
  }
}
