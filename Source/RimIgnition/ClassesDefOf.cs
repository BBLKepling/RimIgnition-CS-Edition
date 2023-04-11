using RimWorld;
using Verse;

namespace RimIgnition
{
    [DefOf]
    public static class ClassesDefOf
    {
        //Vanilla Furniture Expanded
        public static ThingDef Stone_Campfire;
        //Medieval Overhaul
        public static ThingDef DankPyon_RusticTorchLamp;
        public static ThingDef DankPyon_WallTorch;

        static ClassesDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(ClassesDefOf));
        }
    }
}