using RimWorld;
using Verse;

namespace RimIgnitionMO
{
    [DefOf]
    public class ThingDefOfMO
    {
        public static ThingDef DankPyon_RusticTorchLamp;
        public static ThingDef DankPyon_WallTorch;

        static ThingDefOfMO()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(ThingDefOfMO));
        }
    }
}
