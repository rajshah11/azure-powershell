// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SupportPlanResponseEnvelope = Microsoft.Azure.Management.Addons.Models.CanonicalSupportPlanResponseEnvelope;

namespace Microsoft.Azure.Commands.Addons.Models
{
    public class PsSupportPlanResponse
    {
        public string SupportPlanType { get; }
        public string ProvisioningState { get; }

        public PsSupportPlanResponse()
        {
        }

        public PsSupportPlanResponse(SupportPlanResponseEnvelope supportPlanResponseEnvelope)
        {
            this.SupportPlanType = supportPlanResponseEnvelope.Name;
            this.ProvisioningState = supportPlanResponseEnvelope.ProvisioningState.ToString();
        }

        public PsSupportPlanResponse(string supportPlanType, string provisioningState)
        {
            this.SupportPlanType = supportPlanType;
            this.ProvisioningState = provisioningState;
        }

    }
}
