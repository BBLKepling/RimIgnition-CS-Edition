using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimIgnition
{
    [AttributeUsage(AttributeTargets.Field)]
    public class MayRequireCopyAttribute : Attribute
    {
        public string modId;

        public MayRequireCopyAttribute(string modId)
        {
            this.modId = modId;
        }
    }

}
