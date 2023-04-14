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
            if (ModsConfig.IdeologyActive)
            {
                List<Thing> ignitablesDarktorch = map.listerThings.ThingsOfDef(ClassesDefOf.Darktorch);
                for (int i = 0; i < ignitablesDarktorch.Count; i++)
                {
                    Building building = (Building)ignitablesDarktorch[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
                List<Thing> ignitablesDarktorchFungus = map.listerThings.ThingsOfDef(ClassesDefOf.DarktorchFungus);
                for (int i = 0; i < ignitablesDarktorchFungus.Count; i++)
                {
                    Building building = (Building)ignitablesDarktorchFungus[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
            }
            if (ModsConfig.RoyaltyActive && ModsConfig.IdeologyActive)
            {
                List<Thing> ignitablesDarklightBrazier = map.listerThings.ThingsOfDef(ClassesDefOf.DarklightBrazier);
                for (int i = 0; i < ignitablesDarklightBrazier.Count; i++)
                {
                    Building building = (Building)ignitablesDarklightBrazier[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
            }
            if (ModLister.HasActiveModWithName("Alpha Bees"))
            {
                List<Thing> ignitablesABCandle = map.listerThings.ThingsOfDef(ClassesDefOf.RB_WaxCandle);
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
            if (ModLister.HasActiveModWithName("Medieval Overhaul"))
            {
                List<Thing> ignitablesMOTorchLamp = map.listerThings.ThingsOfDef(ClassesDefOf.DankPyon_RusticTorchLamp);
                for (int i = 0; i < ignitablesMOTorchLamp.Count; i++)
                {
                    Building building = (Building)ignitablesMOTorchLamp[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
                List<Thing> ignitablesMOWallTorch = map.listerThings.ThingsOfDef(ClassesDefOf.DankPyon_WallTorch);
                for (int i = 0; i < ignitablesMOWallTorch.Count; i++)
                {
                    Building building = (Building)ignitablesMOWallTorch[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
                List<Thing> ignitablesMOWallLamp = map.listerThings.ThingsOfDef(ClassesDefOf.DankPyon_WallLamp);
                for (int i = 0; i < ignitablesMOWallLamp.Count; i++)
                {
                    Building building = (Building)ignitablesMOWallLamp[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
                List<Thing> ignitablesMOLampPost = map.listerThings.ThingsOfDef(ClassesDefOf.DankPyon_LampPost);
                for (int i = 0; i < ignitablesMOLampPost.Count; i++)
                {
                    Building building = (Building)ignitablesMOLampPost[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
                List<Thing> ignitablesMOCandle = map.listerThings.ThingsOfDef(ClassesDefOf.DankPyon_Candles);
                for (int i = 0; i < ignitablesMOCandle.Count; i++)
                {
                    Building building = (Building)ignitablesMOCandle[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
                List<Thing> ignitablesMOCandleWax = map.listerThings.ThingsOfDef(ClassesDefOf.DankPyon_Candles_Beeswax);
                for (int i = 0; i < ignitablesMOCandleWax.Count; i++)
                {
                    Building building = (Building)ignitablesMOCandleWax[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
                List<Thing> ignitablesMOCandleStand = map.listerThings.ThingsOfDef(ClassesDefOf.DankPyon_CandleStand);
                for (int i = 0; i < ignitablesMOCandleStand.Count; i++)
                {
                    Building building = (Building)ignitablesMOCandleStand[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
                List<Thing> ignitablesMORusticLamp = map.listerThings.ThingsOfDef(ClassesDefOf.DankPyon_RusticLamp);
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
            if (ModLister.HasActiveModWithName("Stick Lantern (Continued)"))
            {
                List<Thing> ignitablesStickLantern = map.listerThings.ThingsOfDef(ClassesDefOf.DR_StickLantern);
                for (int i = 0; i < ignitablesStickLantern.Count; i++)
                {
                    Building building = (Building)ignitablesStickLantern[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
                if (ModsConfig.RoyaltyActive)
                {
                    List<Thing> ignitablesDarkStickLantern = map.listerThings.ThingsOfDef(ClassesDefOf.DR_DarkStickLantern);
                    for (int i = 0; i < ignitablesDarkStickLantern.Count; i++)
                    {
                        Building building = (Building)ignitablesDarkStickLantern[i];
                        CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                        if (refuelComp == null || refuelComp.HasFuel)
                        {
                            yield return building;
                        }
                    }
                }
            }
            if (ModLister.HasActiveModWithName("Undergrounders: Darkfire"))
            {
                List<Thing> ignitablesUGDFCampFire = map.listerThings.ThingsOfDef(ClassesDefOf.undrgdrs_Darkfire);
                for (int i = 0; i < ignitablesUGDFCampFire.Count; i++)
                {
                    Building building = (Building)ignitablesUGDFCampFire[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
                List<Thing> ignitablesUGDFunCampFire = map.listerThings.ThingsOfDef(ClassesDefOf.undrgdrs_FungusDarkfire);
                for (int i = 0; i < ignitablesUGDFunCampFire.Count; i++)
                {
                    Building building = (Building)ignitablesUGDFunCampFire[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
                if (ModsConfig.RoyaltyActive)
                {
                    List<Thing> ignitablesUGFunBrazier = map.listerThings.ThingsOfDef(ClassesDefOf.undrgdrs_FungusDarklightBrazier);
                    for (int i = 0; i < ignitablesUGFunBrazier.Count; i++)
                    {
                        Building building = (Building)ignitablesUGFunBrazier[i];
                        CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                        if (refuelComp == null || refuelComp.HasFuel)
                        {
                            yield return building;
                        }
                    }
                }
            }
            if (ModLister.HasActiveModWithName("Vanilla Furniture Expanded"))
            {
                List<Thing> ignitablesVFECampFire = map.listerThings.ThingsOfDef(ClassesDefOf.Stone_Campfire);
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
            if (ModLister.HasActiveModWithName("Wall Torches Expanded") || ModLister.HasActiveModWithName("Wall Torches Expanded Easy") || ModLister.HasActiveModWithName("Wall Torches N Grill Tech"))
            {
                List<Thing> ignitablesEarlyWallTorch = map.listerThings.ThingsOfDef(ClassesDefOf.EarlyWallTorch);
                for (int i = 0; i < ignitablesEarlyWallTorch.Count; i++)
                {
                    Building building = (Building)ignitablesEarlyWallTorch[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
                List<Thing> ignitablesWallTorch = map.listerThings.ThingsOfDef(ClassesDefOf.WallTorch);
                for (int i = 0; i < ignitablesWallTorch.Count; i++)
                {
                    Building building = (Building)ignitablesWallTorch[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
                List<Thing> ignitablesWallFuelOilTorch = map.listerThings.ThingsOfDef(ClassesDefOf.WallFuelOilTorch);
                for (int i = 0; i < ignitablesWallFuelOilTorch.Count; i++)
                {
                    Building building = (Building)ignitablesWallFuelOilTorch[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
                List<Thing> ignitablesCeilingTorch = map.listerThings.ThingsOfDef(ClassesDefOf.CeilingTorch);
                for (int i = 0; i < ignitablesCeilingTorch.Count; i++)
                {
                    Building building = (Building)ignitablesCeilingTorch[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
                List<Thing> ignitablesCeilingFuelOilTorch = map.listerThings.ThingsOfDef(ClassesDefOf.CeilingFuelOilTorch);
                for (int i = 0; i < ignitablesCeilingFuelOilTorch.Count; i++)
                {
                    Building building = (Building)ignitablesCeilingFuelOilTorch[i];
                    CompRefuelable refuelComp = building.GetComp<CompRefuelable>();
                    if (refuelComp == null || refuelComp.HasFuel)
                    {
                        yield return building;
                    }
                }
            }
        }

        public static bool TryIgniteFireNear(Building culprit)
        {
            Map map = culprit.Map;
            List<IntVec3> tmpCells = new List<IntVec3>();
            int num = GenRadial.NumCellsInRadius(2f);
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
