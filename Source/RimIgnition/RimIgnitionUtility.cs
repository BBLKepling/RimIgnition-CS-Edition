using RimWorld;
using System.Collections.Generic;
using Verse;

namespace RimIgnition
{
    public static class RimIgnitionUtility
    {

        public static IEnumerable<Building> GetIgnitables(Map map)
        {
            List<Thing> ignitables = map.listerThings.ThingsOfDef(ThingDefOf.Campfire);
            ignitables.AddRange(map.listerThings.ThingsOfDef(ThingDefOf.TorchLamp));
            if (ModsConfig.RoyaltyActive)
            {
                ignitables.AddRange(map.listerThings.ThingsOfDef(ThingDefOf.Brazier));
            }
            /*
            if (ModLister.HasActiveModWithName("Vanilla Furniture Expanded"))
            {
                ignitables.AddRange(map.listerThings.ThingsOfDef(ThingDefOf.Stone_Campfire));
            }
            if (ModLister.HasActiveModWithName("Medieval Overhaul"))
            {
                ignitables.AddRange(map.listerThings.ThingsOfDef(ThingDefOf.DankPyon_RusticTorchLamp));
                ignitables.AddRange(map.listerThings.ThingsOfDef(ThingDefOf.DankPyon_WallTorch));
            }
            */
            for (int i = 0; i < ignitables.Count; i++)
            {
                Building building = (Building)ignitables[i];
                CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                if (refuelComp == null || refuelComp.HasFuel)
                {
                    yield return building;
                }
            }
        }

        public static bool TryIgniteFireNear(Building b)
        {
            List<IntVec3> tmpCells = new List<IntVec3>();
            int num = GenRadial.NumCellsInRadius(3f);
            CellRect startRect = b.OccupiedRect();
            for (int i = 0; i < num; i++)
            {
                IntVec3 intVec = b.Position + GenRadial.RadialPattern[i];
                if (GenSight.LineOfSight(b.Position, intVec, b.Map, startRect, CellRect.SingleCell(intVec)) && FireUtility.ChanceToStartFireIn(intVec, b.Map) > 0f)
                {
                    tmpCells.Add(intVec);
                }
            }
            if (tmpCells.Any())
            {
                return FireUtility.TryStartFireIn(tmpCells.RandomElement(), b.Map, Rand.Range(0.1f, 1.75f));
            }
            return false;
        }
    }
}
