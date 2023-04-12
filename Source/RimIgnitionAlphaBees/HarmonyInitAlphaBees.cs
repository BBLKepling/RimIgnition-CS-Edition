using HarmonyLib;
using Verse;

namespace RimIgnitionAlphaBees
{
    [StaticConstructorOnStartup]
    public static class HarmonyInitAlphaBees
    {
        static HarmonyInitAlphaBees()
        {
            Harmony harmonyInstance = new Harmony("BBLKepling.RimIgnition.AlphaBees");
            harmonyInstance.PatchAll();
        }
    }
}
