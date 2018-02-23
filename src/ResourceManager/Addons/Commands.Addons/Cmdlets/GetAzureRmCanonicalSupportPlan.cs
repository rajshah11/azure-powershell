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
using Microsoft.Azure.Commands.Addons.Common;
using Microsoft.Azure.Commands.ResourceManager.Common;
using System.Management.Automation;
using Microsoft.Azure.Commands.Addons.Models;
using System.Resources;
using Microsoft.Azure.Management.Addons;
using Microsoft.Azure.Management.Addons.Models;
using Microsoft.Rest.Azure;

namespace Microsoft.Azure.Commands.Addons.Cmdlets
{
    /// <summary>
    /// Get-AzureRmCanonicalSupportPlan Cmdlet - This cmdlet gives details about the Canonical Support Plan enabled for the subscription
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "AzureRmCanonicalSupportPlan", SupportsShouldProcess = false, 
        ConfirmImpact = ConfirmImpact.Medium), OutputType(typeof(PsSupportPlanResponse), typeof(string))]
    public class GetAzureRmCanonicalSupportPlan : AzureAddonsCmdletBase
    {
        public override void ExecuteCmdlet()
        {
            try
            {
                var essentialResponse =
                    AzureAddonsRpClient.SupportPlanTypes.GetWithHttpMessagesAsync(Constants.ProviderNames.Canonical, 
                    CanonicalSupportPlanTypes.Essential.ToString());
                var standardResponse =
                    AzureAddonsRpClient.SupportPlanTypes.GetWithHttpMessagesAsync(Constants.ProviderNames.Canonical, 
                    CanonicalSupportPlanTypes.Standard.ToString());
                var advancedResponse =
                    AzureAddonsRpClient.SupportPlanTypes.GetWithHttpMessagesAsync(Constants.ProviderNames.Canonical, 
                    CanonicalSupportPlanTypes.Advanced.ToString());

                Task.WaitAll(essentialResponse, standardResponse, advancedResponse);

                if (essentialResponse.Result.Response.IsSuccessStatusCode)
                {
                    WriteObject(new PsSupportPlanResponse(essentialResponse.Result.Body));
                }
                else if (standardResponse.Result.Response.IsSuccessStatusCode)
                {
                    WriteObject(new PsSupportPlanResponse(standardResponse.Result.Body));
                }
                else if (advancedResponse.Result.Response.IsSuccessStatusCode)
                {
                    WriteObject(new PsSupportPlanResponse(advancedResponse.Result.Body));
                }
                else
                {
                    WriteObject("Canonical Support Plan is not purchased for this subscription.");
                }
            }
            catch (Exception ex)
            {
                WriteWarning(ex.Message);
            }
        }
    }
}
