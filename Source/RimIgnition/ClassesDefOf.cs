using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace RimIgnition
{
    [DefOf]
    public class ClassesDefOf
    {
        [MayRequireIdeology]
        public static ThingDef Darktorch;
        [MayRequireIdeology]
        public static ThingDef DarktorchFungus;
        [MayRequireAnyOf("ludeon.rimworld.ideology")]
        [MayRequireRoyalty]
        public static ThingDef DarklightBrazier;
        // Alpha Bees
        [MayRequire("sarg.rimbees")]
        public static ThingDef RB_WaxCandle;
        // Medieval Overhaul
        [MayRequire("dankpyon.medieval.overhaul")]
        public static ThingDef DankPyon_RusticTorchLamp;
        [MayRequire("dankpyon.medieval.overhaul")]
        public static ThingDef DankPyon_WallTorch;
        [MayRequire("dankpyon.medieval.overhaul")]
        public static ThingDef DankPyon_WallLamp;
        [MayRequire("dankpyon.medieval.overhaul")]
        public static ThingDef DankPyon_LampPost;
        [MayRequire("dankpyon.medieval.overhaul")]
        public static ThingDef DankPyon_Candles;
        [MayRequire("dankpyon.medieval.overhaul")]
        public static ThingDef DankPyon_Candles_Beeswax;
        [MayRequire("dankpyon.medieval.overhaul")]
        public static ThingDef DankPyon_CandleStand;
        [MayRequire("dankpyon.medieval.overhaul")]
        public static ThingDef DankPyon_RusticLamp;
        // Stick Lantern (Continued)
        [MayRequire("Mlie.StickLantern")]
        public static ThingDef DR_StickLantern;
        [MayRequireAnyOf("Mlie.StickLantern")]
        [MayRequireIdeology]
        public static ThingDef DR_DarkStickLantern;
        // Undergrounders: Darkfire
        [MayRequire("BattIeBear.Undergrounders.Darkfire")]
        public static ThingDef undrgdrs_Darkfire;
        [MayRequire("BattIeBear.Undergrounders.Darkfire")]
        public static ThingDef undrgdrs_FungusDarkfire;
        [MayRequireAnyOf("BattIeBear.Undergrounders.Darkfire")]
        [MayRequireRoyalty]
        public static ThingDef undrgdrs_FungusDarklightBrazier;
        // Vanilla Furniture Expanded
        [MayRequire("vanillaexpanded.vfecore")]
        public static ThingDef Stone_Campfire;
        // Wall Torches Expanded
        [MayRequireAnyOf("Hauvega.RetroMod.WallTorchesExpanded,Hauvega.RetroMod.WallTorchesExpandedEasy,Hauvega.RetroMod.WallTorchesNGrillTech")]
        public static ThingDef EarlyWallTorch;
        [MayRequireAnyOf("Hauvega.RetroMod.WallTorchesExpanded,Hauvega.RetroMod.WallTorchesExpandedEasy,Hauvega.RetroMod.WallTorchesNGrillTech")]
        public static ThingDef WallTorch;
        [MayRequireAnyOf("Hauvega.RetroMod.WallTorchesExpanded,Hauvega.RetroMod.WallTorchesExpandedEasy,Hauvega.RetroMod.WallTorchesNGrillTech")]
        public static ThingDef WallFuelOilTorch;
        [MayRequireAnyOf("Hauvega.RetroMod.WallTorchesExpanded,Hauvega.RetroMod.WallTorchesExpandedEasy,Hauvega.RetroMod.WallTorchesNGrillTech")]
        public static ThingDef CeilingTorch;
        [MayRequireAnyOf("Hauvega.RetroMod.WallTorchesExpanded,Hauvega.RetroMod.WallTorchesExpandedEasy,Hauvega.RetroMod.WallTorchesNGrillTech")]
        public static ThingDef CeilingFuelOilTorch;

        static ClassesDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(ClassesDefOf));
        }
    }
}
