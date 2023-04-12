using HarmonyLib;
using RimIgnition;
using RimWorld;
using System.Collections.Generic;
using Verse;

namespace RimIgnitionVFE
{
    [HarmonyPatch(typeof(RimIgnitionUtility), nameof(RimIgnitionUtility.GetIgnitables))]
    class PatchHarmonyVFE
    {
        static IEnumerable<Building> Postfix(IEnumerable<Building> values, Map map)
        {
            foreach (Building value in values)
            {
                yield return value;
            }
            List<Thing> ignitablesVFECampFire = map.listerThings.ThingsOfDef(ThingDefOfVFE.Stone_Campfire);
            for (int i = 0; i < ignitablesVFECampFire.Count; i++)
            {
                Building building = (Building)ignitablesVFECampFire[i];
                CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                if (refuelComp == null || refuelComp.HasFuel)
                {
                    yield return building;
                }
            }
        }
    }
}
