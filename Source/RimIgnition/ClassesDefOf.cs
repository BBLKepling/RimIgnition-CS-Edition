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
        [MayRequireIdeology][MayRequireRoyalty]
        public static ThingDef DarklightBrazier;
        [MayRequire("sarg.rimbees")]
        public static ThingDef RB_WaxCandle;
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
        [MayRequire("vanillaexpanded.vfecore")]
        public static ThingDef Stone_Campfire;

        static ClassesDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(ClassesDefOf));
        }
    }
}
