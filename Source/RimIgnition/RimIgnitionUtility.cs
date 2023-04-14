using RimWorld;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Verse;
using Verse.Noise;

namespace RimIgnition
{
    public static class RimIgnitionUtility
    {

        public static IEnumerable<Building> GetIgnitables(Map map)
        {
            List<Thing> ignitables = map.listerThings.AllThings;
            for (int i = 0; i < ignitables.Count; i++)
            {
                if (ignitables[i] is Building)
                {
                    Building building = (Building)ignitables[i];
                    if (building.def.HasModExtension<RimIgniterModExtension>())
                    {
                        CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                        // the null check is a FU to anyone who patches CompRefuelable off
                        if (refuelComp == null || refuelComp.HasFuel)
                        {
                            yield return building;
                        }
                    }
                }
            }
        }

        public static bool TryIgniteFireNear(Building culprit)
        {
            Map map = culprit.Map;
            List<IntVec3> tmpCells = new List<IntVec3>();
            int num = GenRadial.NumCellsInRadius(culprit.def.GetModExtension<RimIgniterModExtension>().emberRange);
            CellRect startRect = culprit.OccupiedRect();
            for (int i = 0; i < num; i++)
            {
                IntVec3 intVec = culprit.Position + GenRadial.RadialPattern[i];
                if (GenSight.LineOfSight(culprit.Position, intVec, culprit.Map, startRect, CellRect.SingleCell(intVec)) && FireUtility.ChanceToStartFireIn(intVec, culprit.Map) > 0f)
                {
                    tmpCells.Add(intVec);
                }
            }
            if (tmpCells.Any())
            {
                Find.LetterStack.ReceiveLetter("BBLK_LetterLabelIgnite".Translate(), "BBLK_LetterTextIgnite".Translate(culprit.Label, culprit.Named("CULPRIT")), LetterDefOf.NegativeEvent, new TargetInfo(culprit.Position, map));
                return FireUtility.TryStartFireIn(tmpCells.RandomElement(), culprit.Map, Rand.Range(0.1f, 1.00f));
            }
            return false;
        }
    }
}
