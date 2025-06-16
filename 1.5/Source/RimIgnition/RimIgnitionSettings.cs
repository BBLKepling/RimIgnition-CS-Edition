using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace RimIgnition
{
    public class RimIgnitionSettings : ModSettings
    {
        public static bool letter = true;
        public override void ExposeData()
        {
            Scribe_Values.Look(ref letter, "letter");
            base.ExposeData();
        }
    }
    public class RimIgnitionMod : Mod
    {
        public RimIgnitionMod(ModContentPack content) : base(content)
        {
            GetSettings<RimIgnitionSettings>();
        }
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.CheckboxLabeled("BBLK_RimIgnitionLabelLetter".Translate(), ref RimIgnitionSettings.letter, "BBLK_RimIgnitionLetterToolTip".Translate());
            listingStandard.End();
            base.DoSettingsWindowContents(inRect);
        }
        public override string SettingsCategory() => "BBLK_RimIgnition_Settings".Translate();
    }
}
