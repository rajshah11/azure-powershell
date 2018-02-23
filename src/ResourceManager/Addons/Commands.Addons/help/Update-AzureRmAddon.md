---
external help file: Microsoft.Azure.Commands.Addons.dll-Help.xml
Module Name: AzureRM.Addons
online version: 
schema: 2.0.0
---

# Update-AzureRmAddon

## SYNOPSIS
Update the Canonical support plan for the subscription. The support plan type can be Essentials, Standard or Advanced.

## SYNTAX

```
Update-AzureRmAddon [-SupportPlanType] <CanonicalSupportPlanTypes> [-DefaultProfile <IAzureContextContainer>]
 [-WhatIf] [-Confirm]
```

## DESCRIPTION
The **Update-AzureRmAddon** cmdlet updates the Canonical support plan for a subscription. The support plan can be one of the following types - Essentials, Standard or Advanced. 

This cmdlet is idempotent i.e. updating to a Standard plan for a subscription which already has a Standard plan will do nothing.

## EXAMPLES

### Update to an Advanced Canonical support plan for a subscription which has a Standard plan
```
PS C:\> Update-AzureRmAddon -SupportPlanType Advanced
SupportPlanType: Advanced
ProvisioningState: Upgrading
```

The support plan for the subscription upgrades to Advanced since the subscription already had a Standard plan.

### Update to an Essentials Canonical support plan for a subscription which has a Standard plan
```
PS C:\> Update-AzureRmAddon -SupportPlanType Essentials
SupportPlanType: Essentials
ProvisioningState: Downgrading
```

The support plan for the subscription downgrades to Essentials since the subscription already had a Standard plan.

### Update to a Standard Canonical support plan for a subscription which doesn't have a support plan
```
PS C:\> Update-AzureRmAddon -SupportPlanType Standard
SupportPlanType: Standard
ProvisioningState: Purchasing
```

This adds a Standard support plan for the subscription since the subscription didn't have a support plan.

### Update to a Standard Canonical support plan for a subscription which has a Standard plan
```
PS C:\> Update-AzureRmAddon -SupportPlanType Standard
SupportPlanType: Standard
ProvisioningState: Purchased
```

Since a Standard plan was already purchased, the provisioning state remains the same.

## PARAMETERS

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with azure.

```yaml
Type: IAzureContextContainer
Parameter Sets: (All)
Aliases: AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SupportPlanType
Type of the Canonical support plan that will be purchased.
Could be "Standard","Advanced" or "Essentials"

```yaml
Type: CanonicalSupportPlanTypes
Parameter Sets: (All)
Aliases: 
Accepted values: Standard, Advanced, Essentials

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

## INPUTS

### None


## OUTPUTS

### Microsoft.Azure.Commands.Addons.Models.PsSupportPlanResponse
System.String


## NOTES

## RELATED LINKS

