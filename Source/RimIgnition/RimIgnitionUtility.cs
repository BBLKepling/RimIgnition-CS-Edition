using RimWorld;
using System.Collections.Generic;
using Verse;

namespace RimIgnition
{
    public static class RimIgnitionUtility
    {

        public static IEnumerable<Building> GetIgnitables(Map map)
        {
            List<Thing> ignitablesTorch = map.listerThings.ThingsOfDef(ThingDefOf.TorchLamp);
            for (int i = 0; i < ignitablesTorch.Count; i++)
            {
                Building building = (Building)ignitablesTorch[i];
                CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                // the null check is a FU to anyone who patches CompRefuelable off
                if (refuelComp == null || refuelComp.HasFuel)
                {
                    yield return building;
                }
            }
            List<Thing> ignitablesCampfire = map.listerThings.ThingsOfDef(ThingDefOf.Campfire);
            for (int i = 0; i < ignitablesCampfire.Count; i++)
            {
                Building building = (Building)ignitablesCampfire[i];
                CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                if (refuelComp == null || refuelComp.HasFuel)
                {
                    yield return building;
                }
            }
            if (ModsConfig.RoyaltyActive)
            {
                List<Thing> ignitablesBrazier = map.listerThings.ThingsOfDef(ThingDefOf.Brazier);
                for (int i = 0; i < ignitablesBrazier.Count; i++)
                {
                    Building building = (Building)ignitablesBrazier[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
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
