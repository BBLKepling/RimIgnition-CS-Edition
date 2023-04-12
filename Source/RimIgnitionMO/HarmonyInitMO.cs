using HarmonyLib;
using Verse;

namespace RimIgnitionMO
{
    [StaticConstructorOnStartup]
    public static class HarmonyInitMO
    {
        static HarmonyInitMO()
        {
            Harmony harmonyInstance = new Harmony("BBLKepling.RimIgnition.MO");
            harmonyInstance.PatchAll();
        }
    }
}
