using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Commands.Addons.Common;
using Microsoft.Azure.Commands.Addons.Models;
using Microsoft.Azure.Management.Addons.Models;

namespace Microsoft.Azure.Commands.Addons.Cmdlets
{
    /// <summary>
    /// Set-AzureRmCanonicalSupportPlan Cmdlet - This cmdlet gives details about the Canonical Support Plan enabled for the subscription
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "AzureRmCanonicalSupportPlan",
         DefaultParameterSetName = Constants.ParameterSetNames.CanonicalParameterSet, SupportsShouldProcess = true,
         ConfirmImpact = ConfirmImpact.Medium), OutputType(typeof(PsSupportPlanResponse), typeof(string))]
    public class SetAzureRmCanonicalSupportPlan : AzureAddonsCmdletBase
    {
        [Parameter(ParameterSetName = Constants.ParameterSetNames.CanonicalParameterSet, Mandatory = true, HelpMessage = Constants.HelpMessages.Canonical.AddCanonicalPlanTypeHelpMessage, Position = 0)]
        [ValidateSet("Essential", "Standard", "Advanced", "None", IgnoreCase = true)]

        public CanonicalSupportPlanTypes SupportPlanType { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        public override void ExecuteCmdlet()
        {
            try
            {
                if (SupportPlanType.ToString() != "None")
                {
                    if (ShouldProcess(string.Format(Resource.ShouldProcessDescription, "Setting", SupportPlanType),
                        string.Format(Resource.ShouldProcessWarning, "set", SupportPlanType),
                        Resource.ShouldProcessCaption))
                    {
                        var response = AzureAddonsRpClient.SupportPlanTypes
                            .CreateOrUpdateWithHttpMessagesAsync(Constants.ProviderNames.Canonical,
                                SupportPlanType.ToString()).GetAwaiter().GetResult();

                        if (response.Response.IsSuccessStatusCode)
                        {
                            var output = new PsSupportPlanResponse(response.Body);
                            WriteObject(output);
                        }
                    }
                }
                else
                {
                    if (ShouldProcess(Resource.ShouldProcessRemoveDescription,
                        Resource.ShouldProcessRemoveWarning,
                        Resource.ShouldProcessCaption))
                    {
                        var essentialResponse = AzureAddonsRpClient.SupportPlanTypes
                            .DeleteWithHttpMessagesAsync(Constants.ProviderNames.Canonical, CanonicalSupportPlanTypes.Essential.ToString())
                            .GetAwaiter().GetResult();

                        if (essentialResponse.Response.StatusCode == HttpStatusCode.OK)
                        {
                            WriteObject("Essential Canonical Support Plan removed.");
                            return;
                        }

                        var standardResponse = AzureAddonsRpClient.SupportPlanTypes
                            .DeleteWithHttpMessagesAsync(Constants.ProviderNames.Canonical, CanonicalSupportPlanTypes.Standard.ToString())
                            .GetAwaiter().GetResult();

                        if (standardResponse.Response.StatusCode == HttpStatusCode.OK)
                        {
                            WriteObject("Standard Canonical Support Plan removed.");
                            return;
                        }

                        var advancedResponse = AzureAddonsRpClient.SupportPlanTypes
                            .DeleteWithHttpMessagesAsync(Constants.ProviderNames.Canonical, CanonicalSupportPlanTypes.Advanced.ToString())
                            .GetAwaiter().GetResult();

                        if (advancedResponse.Response.StatusCode == HttpStatusCode.OK)
                        {
                            WriteObject("Advanced Canonical Suppport Plan removed.");
                            return;
                        }

                        WriteObject("No Canonical Support Plan found for the subscription.");
                    }
                }
            }
            catch (ErrorDefinitionException ex)
            {
                WriteWarning(ex.Message);
            }
        }

    }
}
