---
external help file: Microsoft.Azure.Commands.Addons.dll-Help.xml
Module Name: AzureRM.Addons
online version: 
schema: 2.0.0
---

# Remove-AzureRmAddon

## SYNOPSIS
Remove or delete the Canonical support plan for the subscription. The support plan type can be Essentials, Standard or Advanced.
## SYNTAX

```
Remove-AzureRmAddon [[-SupportPlanType] <CanonicalSupportPlanTypes>] [-DefaultProfile <IAzureContextContainer>]
 [-WhatIf] [-Confirm]
```

## DESCRIPTION
The **Remove-AzureRmAddon** cmdlet removes or deletes the Canonical support plan of a particular type for the subscription.

## EXAMPLES

### Remove Standard plan for a subscription which has a Standard plan
```
PS C:\> Remove-AzureRmAddon -SupportPlanType Standard
SupportPlanType: Standard
ProvisioningState: Cancelling
```

This removes the Standard support plan for the subscription

### Remove Standard plan for a subscription which does not have a Standard plan
```
PS C:\> Remove-AzureRmAddon -SupportPlanType Standard
SupportPlanType: Standard
ProvisioningState: Not Found
```

This does nothing as the subscription did not have a Standard plan

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
Type of the Canonical support plan to be removed.
Could be "Standard","Advanced" or "Essentials"

```yaml
Type: CanonicalSupportPlanTypes
Parameter Sets: (All)
Aliases: 
Accepted values: Standard, Advanced, Essentials

Required: False
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

