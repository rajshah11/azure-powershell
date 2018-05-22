﻿// ----------------------------------------------------------------------------------
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

using Microsoft.Azure.ServiceManagemenet.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using Xunit;

namespace Microsoft.Azure.Commands.Resources.Test.ScenarioTests
{
    public class ManagementGroupsTests
    {
        public ManagementGroupsTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            XunitTracingInterceptor.AddToContext(new XunitTracingInterceptor(output));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetManagementGroup()
        {
            ResourcesController.NewInstance.RunPsTest("Test-GetManagementGroup");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetManagementGroupWithExpand()
        {
            ResourcesController.NewInstance.RunPsTest("Test-GetManagementGroupWithExpand");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetManagementGroupWithExpandAndRecurse()
        {
            ResourcesController.NewInstance.RunPsTest("Test-GetManagementGroupWithExpandAndRecurse");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestNewManagementGroup()
        {
            ResourcesController.NewInstance.RunPsTest("Test-NewManagementGroup");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestNewManagementGroupWithDisplayName()
        {
            ResourcesController.NewInstance.RunPsTest("Test-NewManagementGroupWithDisplayName");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestNewManagementGroupWithParentId()
        {
            ResourcesController.NewInstance.RunPsTest("Test-NewManagementGroupWithParentId");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestNewManagementGroupWithDisplayNameAndParentId()
        {
            ResourcesController.NewInstance.RunPsTest("Test-NewManagementGroupWithDisplayNameAndParentId");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestUpdateManagementGroupWithDisplayName()
        {
            ResourcesController.NewInstance.RunPsTest("Test-UpdateManagementGroupWithDisplayName");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestUpdateManagementGroupWithParentId()
        {
            ResourcesController.NewInstance.RunPsTest("Test-UpdateManagementGroupWithParentId");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestUpdateManagementGroupWithDisplayNameAndParentId()
        {
            ResourcesController.NewInstance.RunPsTest("Test-UpdateManagementGroupWithDisplayNameAndParentId");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestRemoveManagementGroup()
        {
            ResourcesController.NewInstance.RunPsTest("Test-RemoveManagementGroup");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestNewRemoveManagementGroupSubscription()
        {
            ResourcesController.NewInstance.RunPsTest("Test-NewRemoveManagementGroupSubscription");
        }
    }
}
