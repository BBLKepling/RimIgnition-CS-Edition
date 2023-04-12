using HarmonyLib;
using Verse;

namespace RimIgnitionVFE
{
    [StaticConstructorOnStartup]
    public static class HarmonyInitVFE
    {
        static HarmonyInitVFE()
        {
            Harmony harmonyInstance = new Harmony("BBLKepling.RimIgnition.VFE");
            harmonyInstance.PatchAll();
        }
    }
}
