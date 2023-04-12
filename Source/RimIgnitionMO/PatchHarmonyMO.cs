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
            List<Thing> ignitablesMOWallLamp = map.listerThings.ThingsOfDef(ThingDefOfMO.DankPyon_WallLamp);
            for (int i = 0; i < ignitablesMOWallLamp.Count; i++)
            {
                Building building = (Building)ignitablesMOWallLamp[i];
                CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                if (refuelComp == null || refuelComp.HasFuel)
                {
                    yield return building;
                }
            }
            List<Thing> ignitablesMOLampPost = map.listerThings.ThingsOfDef(ThingDefOfMO.DankPyon_LampPost);
            for (int i = 0; i < ignitablesMOLampPost.Count; i++)
            {
                Building building = (Building)ignitablesMOLampPost[i];
                CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                if (refuelComp == null || refuelComp.HasFuel)
                {
                    yield return building;
                }
            }
            List<Thing> ignitablesMOCandle = map.listerThings.ThingsOfDef(ThingDefOfMO.DankPyon_Candles);
            for (int i = 0; i < ignitablesMOCandle.Count; i++)
            {
                Building building = (Building)ignitablesMOCandle[i];
                CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                if (refuelComp == null || refuelComp.HasFuel)
                {
                    yield return building;
                }
            }
            List<Thing> ignitablesMOCandleWax = map.listerThings.ThingsOfDef(ThingDefOfMO.DankPyon_Candles_Beeswax);
            for (int i = 0; i < ignitablesMOCandleWax.Count; i++)
            {
                Building building = (Building)ignitablesMOCandleWax[i];
                CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                if (refuelComp == null || refuelComp.HasFuel)
                {
                    yield return building;
                }
            }
            List<Thing> ignitablesMOCandleStand = map.listerThings.ThingsOfDef(ThingDefOfMO.DankPyon_CandleStand);
            for (int i = 0; i < ignitablesMOCandleStand.Count; i++)
            {
                Building building = (Building)ignitablesMOCandleStand[i];
                CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                if (refuelComp == null || refuelComp.HasFuel)
                {
                    yield return building;
                }
            }
            List<Thing> ignitablesMORusticLamp = map.listerThings.ThingsOfDef(ThingDefOfMO.DankPyon_RusticLamp);
            for (int i = 0; i < ignitablesMORusticLamp.Count; i++)
            {
                Building building = (Building)ignitablesMORusticLamp[i];
                CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                if (refuelComp == null || refuelComp.HasFuel)
                {
                    yield return building;
                }
            }
        }
    }
}
