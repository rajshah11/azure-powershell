---
external help file: Microsoft.Azure.Commands.Addons.dll-Help.xml
Module Name: AzureRM.Addons
online version: 
schema: 2.0.0
---

# Add-AzureRmAddon

## SYNOPSIS
Add or purchase a Canonical support plan for the subscription. The support plan type can be Essentials, Standard or Advanced.

## SYNTAX

```
Add-AzureRmAddon [-SupportPlanType] <CanonicalSupportPlanTypes> [-DefaultProfile <IAzureContextContainer>]
 [-WhatIf] [-Confirm]
```

## DESCRIPTION
The **Add-AzureRmAddon** cmdlet adds or purchases a Canonical support plan. The support plan can be one of the following types - Essentials, Standard or Advanced. 

This cmdlet is idempotent i.e. adding a Standard plan for a subscription which already has a Standard plan will do nothing. Also, a subscription can have only one support plan type, which implies that adding an Advanced plan for subscription which has an Essentials plan will first disable the Essentials plan and then purchase an Advanced plan.

## EXAMPLES

### Add a Standard Canonical support plan for a subscription which doesn't have a support plan
```
PS C:\> Add-AzureRmAddon -SupportPlanType Standard
SupportPlanType: Standard
ProvisioningState: Purchasing
```

This adds a Standard support plan for the subscription.

### Add a Standard Canonical support plan for a subscription which has a Standard plan
```
PS C:\> Add-AzureRmAddon -SupportPlanType Standard
SupportPlanType: Standard
ProvisioningState: Purchased
```

Since a Standard plan was already purchased, the provisioning state remains the same.

### Add an Advanced Canonical support plan for a subscription which has a Standard plan
```
PS C:\> Add-AzureRmAddon -SupportPlanType Advanced
SupportPlanType: Advanced
ProvisioningState: Upgrading
```

The support plan for the subscription upgrades to Advanced since the subscription already had a Standard plan.

### Add an Essentials Canonical support plan for a subscription which has a Standard plan
```
PS C:\> Add-AzureRmAddon -SupportPlanType Essentials
SupportPlanType: Essentials
ProvisioningState: Downgrading
```

The support plan for the subscription downgrades to Essentials since the subscription already had a Standard plan.


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
Could be Standard, Advanced or Essentials

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


## NOTES

## RELATED LINKS

