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
using Microsoft.Azure.Commands.Addons.Test.ScenarioTests.ScenarioTest;
using Microsoft.Azure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;

namespace Microsoft.Azure.Commands.Addons.Test.ScenarioTests
{
    public class CanonicalSupportPlanTests
    {
        private Microsoft.Azure.ServiceManagemenet.Common.Models.XunitTracingInterceptor _logger;

        public CanonicalSupportPlanTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            _logger = new Microsoft.Azure.ServiceManagemenet.Common.Models.XunitTracingInterceptor(output);
            Microsoft.Azure.ServiceManagemenet.Common.Models.XunitTracingInterceptor.AddToContext(_logger);
            TestExecutionHelpers.SetUpSessionAndProfile();
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPurchaseStandard()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, @"Test-PurchaseStandard");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestUpgradeAdvanced()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, @"Test-UpgradeAdvanced");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDowngradeEssential()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, @"Test-DowngradeEssential");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetCanonicalSupportPlan()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, @"Test-GetCanonicalSupportPlan");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestRemoveSupportPlan()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, @"Test-RemoveSupportPlan");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetNoneCanonicalSupportPlan()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, @"Test-GetNoneCanonicalSupportPlan");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestRemoveNoneCanonicalSupportPlan()
        {
            TestController.NewInstance.RunPowerShellTest(_logger, @"Test-RemoveNoneCanonicalSupportPlan");
        }


    }
}