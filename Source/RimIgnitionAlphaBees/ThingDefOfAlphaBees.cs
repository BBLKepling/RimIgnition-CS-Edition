using RimWorld;
using Verse;

namespace RimIgnitionAlphaBees
{
    [DefOf]
    public class ThingDefOfAlphaBees
    {
        public static ThingDef RB_WaxCandle;

        static ThingDefOfAlphaBees()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(ThingDefOfAlphaBees));
        }
    }
}
