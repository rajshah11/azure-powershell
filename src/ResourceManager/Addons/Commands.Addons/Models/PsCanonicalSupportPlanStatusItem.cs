using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CanonicalSupportPlanStatusItem = Microsoft.Azure.Management.Addons.Models.CanonicalSupportPlanStatusItem;

namespace Microsoft.Azure.Commands.Addons.Models
{
    public class PsCanonicalSupportPlanStatusItem
    {

        public string SupportPlanType { get; }
        public string Enabled { get; }
        public PsCanonicalSupportPlanStatusItem(CanonicalSupportPlanStatusItem canonicalSupportPlanStatusItem)
        {
            this.SupportPlanType = canonicalSupportPlanStatusItem.SupportPlanType;
            this.Enabled = canonicalSupportPlanStatusItem.Enabled.ToString();
        }
    }
}
