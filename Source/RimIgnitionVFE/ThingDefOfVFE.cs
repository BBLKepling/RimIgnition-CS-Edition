using RimWorld;
using Verse;

namespace RimIgnitionVFE
{
    [DefOf]
    public class ThingDefOfVFE
    {
        public static ThingDef Stone_Campfire;

        static ThingDefOfVFE()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(ThingDefOfVFE));
        }
    }
}
