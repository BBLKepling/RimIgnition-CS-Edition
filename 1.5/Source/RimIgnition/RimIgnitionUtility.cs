using RimWorld;
using System.Collections.Generic;
using Verse;

namespace RimIgnition
{
    public static class RimIgnitionUtility
    {

        public static IEnumerable<Building> GetIgnitables(Map map)
        {
            List<Building> ignitables = map.listerBuildings.allBuildingsColonist;
            for (int i = 0; i < ignitables.Count; i++)
            {
                if (!(ignitables[i].def.GetModExtension<RimIgniterModExtension>() is RimIgniterModExtension modEx) || 
                    (ignitables[i].GetComp<CompRefuelable>() is CompRefuelable refuelComp && !refuelComp.HasFuel) || 
                    (ignitables[i].GetComp<CompFlickable>() is CompFlickable flickComp && !flickComp.SwitchIsOn)) { continue; }
                List<IntVec3> tmpCells = new List<IntVec3>();
                int num = GenRadial.NumCellsInRadius(modEx.emberRange);
                CellRect startRect = ignitables[i].OccupiedRect();
                for (int q = 0; q < num; q++)
                {
                    IntVec3 intVec = ignitables[i].Position + GenRadial.RadialPattern[q];
                    if (GenSight.LineOfSight(ignitables[i].Position, intVec, map, startRect, CellRect.SingleCell(intVec)) && FireUtility.ChanceToStartFireIn(intVec, map) > 0f)
                    {
                        tmpCells.Add(intVec);
                    }
                }
                if (tmpCells.Any())
                {
                    yield return ignitables[i];
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
                if (RimIgnitionSettings.letter)
                {
                    Find.LetterStack.ReceiveLetter("BBLK_LetterLabelIgnite".Translate(), "BBLK_LetterTextIgnite".Translate(culprit.Label, culprit.Named("CULPRIT")), LetterDefOf.NegativeEvent, new TargetInfo(culprit.Position, map));
                }
                return FireUtility.TryStartFireIn(tmpCells.RandomElement(), culprit.Map, Rand.Range(0.1f, 1.00f), culprit);
            }
            return false;
        }
    }
}
