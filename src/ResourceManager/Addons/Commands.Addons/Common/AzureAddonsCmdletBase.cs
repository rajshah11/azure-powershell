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

using System.Collections.Generic;
using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.ResourceManager.Common;
using Microsoft.Azure.Management.Addons;

namespace Microsoft.Azure.Commands.Addons.Common
{
    /// <summary>
    /// Base class of Azure Addons Cmdlet.
    /// </summary>
    public abstract class AzureAddonsCmdletBase : AzureRMCmdlet
    {
        private IAzureAddonsResourceProviderClient _azureAddonsrpClient;

        private Dictionary<string, List<string>> _defaultRequestHeaders;

        /// <summary>
        /// Gets or sets the Addons RP client.
        /// </summary>
        public IAzureAddonsResourceProviderClient AzureAddonsRpClient
        {
            get
            {
                return _azureAddonsrpClient ??
                       (_azureAddonsrpClient =
                           AzureSession.Instance.ClientFactory.CreateArmClient<AzureAddonsResourceProviderClient>(DefaultProfile.DefaultContext,
                               AzureEnvironment.Endpoint.ResourceManager));
            }
            set { _azureAddonsrpClient = value; }
        }
    }
}
