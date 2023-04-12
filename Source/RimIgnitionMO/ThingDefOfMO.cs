using RimWorld;
using Verse;

namespace RimIgnitionMO
{
    [DefOf]
    public class ThingDefOfMO
    {
        public static ThingDef DankPyon_RusticTorchLamp;
        public static ThingDef DankPyon_WallTorch;
        public static ThingDef DankPyon_WallLamp;
        public static ThingDef DankPyon_LampPost;
        public static ThingDef DankPyon_Candles;
        public static ThingDef DankPyon_Candles_Beeswax;
        public static ThingDef DankPyon_CandleStand;
        public static ThingDef DankPyon_RusticLamp;

        static ThingDefOfMO()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(ThingDefOfMO));
        }
    }
}
