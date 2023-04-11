using RimWorld;
using Verse;

namespace RimIgnition
{
    [DefOf]
    public static class ClassesDefOf
    {
        public static ThingDef Stone_Campfire;

        public static ThingDef DankPyon_RusticTorchLamp;
        public static ThingDef DankPyon_WallTorch;

        static ClassesDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(ClassesDefOf));
        }
    }
}