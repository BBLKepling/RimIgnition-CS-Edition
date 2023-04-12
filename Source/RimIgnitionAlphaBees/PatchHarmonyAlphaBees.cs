using HarmonyLib;
using RimIgnition;
using RimWorld;
using System.Collections.Generic;
using Verse;

namespace RimIgnitionAlphaBees
{
    [HarmonyPatch(typeof(RimIgnitionUtility), nameof(RimIgnitionUtility.GetIgnitables))]
    class PatchHarmonyAlphaBees
    {
        static IEnumerable<Building> Postfix(IEnumerable<Building> values, Map map)
        {
            foreach (Building value in values)
            {
                yield return value;
            }
            List<Thing> ignitablesABCandle = map.listerThings.ThingsOfDef(ThingDefOfAlphaBees.RB_WaxCandle);
            for (int i = 0; i < ignitablesABCandle.Count; i++)
            {
                Building building = (Building)ignitablesABCandle[i];
                CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                if (refuelComp == null || refuelComp.HasFuel)
                {
                    yield return building;
                }
            }
        }
    }
}
