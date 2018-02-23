# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.SYNOPSIS
Purchase standard
#>
function Test-PurchaseStandard
{
	$SupportPlanType = "Standard"
    $response = Set-AzureRmCanonicalSupportPlan -SupportPlanType Standard
	Assert-AreEqual $response.SupportPlanType $SupportPlanType
	Assert-AreEqual $response.ProvisioningState "Succeeded"

}

function Test-UpgradeAdvanced
{
	$SupportPlanType = "Advanced"
    $response = Set-AzureRmCanonicalSupportPlan -SupportPlanType Advanced
	Assert-AreEqual $response.SupportPlanType $SupportPlanType
	Assert-AreEqual $response.ProvisioningState "Succeeded"

}

function Test-DowngradeEssential
{
	$SupportPlanType = "Essential"
    $response = Set-AzureRmCanonicalSupportPlan -SupportPlanType Essential
	Assert-AreEqual $response.SupportPlanType $SupportPlanType
	Assert-AreEqual $response.ProvisioningState "Succeeded"
}

function Test-GetCanonicalSupportPlan
{
	$SupportPlanType = "Essential"
	Set-AzureRmCanonicalSupportPlan -SupportPlanType Essential
    $response = Get-AzureRmCanonicalSupportPlan
	Assert-AreEqual $response.SupportPlanType $SupportPlanType
	Assert-AreEqual $response.ProvisioningState "Succeeded"
}

function Test-RemoveSupportPlan
{
	Set-AzureRmCanonicalSupportPlan -SupportPlanType Essential
    $response = Set-AzureRmCanonicalSupportPlan -SupportPlanType None
	Assert-AreEqual $response "Essential Canonical Support Plan removed."
}

function Test-GetNoneCanonicalSupportPlan
{
	Set-AzureRmCanonicalSupportPlan -SupportPlanType None
    $response = Get-AzureRmCanonicalSupportPlan
	Assert-AreEqual $response "Canonical Support Plan is not purchased for this subscription."
}

function Test-RemoveNoneCanonicalSupportPlan
{
	Set-AzureRmCanonicalSupportPlan -SupportPlanType None
    $response = Set-AzureRmCanonicalSupportPlan -SupportPlanType None
	Assert-AreEqual $response "No Canonical Support Plan found for the subscription."
}