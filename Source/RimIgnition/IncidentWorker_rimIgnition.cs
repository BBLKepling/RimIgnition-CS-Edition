﻿using RimWorld;
using System.Linq;
using Verse;

namespace RimIgnition
{
    public class IncidentWorker_RimIgnition : IncidentWorker
    {
        protected override bool CanFireNowSub(IncidentParms parms)
        {
            return RimIgnitionUtility.GetIgnitables((Map)parms.target).Any();
        }

        protected override bool TryExecuteWorker(IncidentParms parms)
        {
            if (!RimIgnitionUtility.GetIgnitables((Map)parms.target).TryRandomElement(out var result))
            {
                return false;
            }
            return RimIgnitionUtility.TryIgniteFireNear(result);
        }
    }
}
