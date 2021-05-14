using UnityEngine;

namespace PlantsInPots.Shared
{
  class Constants
  {
    public readonly static string ModName = "PlantsInPots";
    public static string BundleName { get { return $"{ModName.ToLower()}_assets"; } }
    public static string BundlePath { get { return $"{Application.dataPath}/Assets/{BundleName}"; } }
  }
}
