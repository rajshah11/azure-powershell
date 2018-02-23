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

namespace Microsoft.Azure.Commands.Addons.Common
{
    /// <summary>
    /// Constants used by all Cmdlets
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// Parameter Set names used by the cmdlets
        /// </summary>
        public class ParameterSetNames
        {
            public const string CanonicalParameterSet = "Canonical";
        }

        public class HelpMessages
        {
            public class Canonical
            {
                public const string AddCanonicalPlanTypeHelpMessage =
                    "Type of the Canonical support plan that will be purchased. Could be \"Standard\",\"Advanced\" or \"Essential\"";

                public const string UpdateCanonicalPlanTypeHelpMessage =
                    "Type of the Canonical support plan. Could be \"Standard\",\"Advanced\" or \"Essential\"";

                public const string RemoveCanonicalPlanTypeHelpMessage =
                    "Type of the Canonical support plan to be removed. Could be \"Standard\",\"Advanced\" or \"Essential\"";

                public const string GetCanonicalPlanTypeHelpMessage =
                    "Type of the Canonical support plan. Could be \"Standard\",\"Advanced\" or \"Essential\"";

            }
        }

        public class ProviderNames
        {
            public const string Canonical = "Canonical";
        }

    }
}
