using HarmonyLib;
using RimIgnition;
using RimWorld;
using System.Collections.Generic;
using Verse;

namespace RimIgnitionMO
{
    [HarmonyPatch(typeof(RimIgnitionUtility), nameof(RimIgnitionUtility.GetIgnitables))]
    class PatchHarmonyMO
    {
        static IEnumerable<Building> Postfix(IEnumerable<Building> values, Map map)
        {
            foreach (Building value in values)
            {
                yield return value;
            }
            List<Thing> ignitablesMOTorchLamp = map.listerThings.ThingsOfDef(ThingDefOfMO.DankPyon_RusticTorchLamp);
            for (int i = 0; i < ignitablesMOTorchLamp.Count; i++)
            {
                Building building = (Building)ignitablesMOTorchLamp[i];
                CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                if (refuelComp == null || refuelComp.HasFuel)
                {
                    yield return building;
                }
            }
            List<Thing> ignitablesMOWallTorch = map.listerThings.ThingsOfDef(ThingDefOfMO.DankPyon_WallTorch);
            for (int i = 0; i < ignitablesMOWallTorch.Count; i++)
            {
                Building building = (Building)ignitablesMOWallTorch[i];
                CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                if (refuelComp == null || refuelComp.HasFuel)
                {
                    yield return building;
                }
            }
        }
    }
}
