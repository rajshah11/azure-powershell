---
external help file: Microsoft.Azure.Commands.Addons.dll-Help.xml
Module Name: AzureRM.Addons
online version: 
schema: 2.0.0
---

# Get-AzureRmAddon

## SYNOPSIS
Get the Canonical support plan details for the subscription.

## SYNTAX

```
Get-AzureRmAddon [[-SupportPlanType] <CanonicalSupportPlanTypesExtension>]
 [-DefaultProfile <IAzureContextContainer>]
```

## DESCRIPTION
The **Get-AzureRmAddon** cmdlet gives details about the support plan of a particular type for the subscription. If ```-All``` or no input is given for the support plan type, this cmdlet shows the ```Enabled``` state for each support plan type. 

## EXAMPLES

### Get Standard support plan for a subscription which has a Standard support plan
```
PS C:\> Get-AzureRmAddon -SupportPlanType Standard
SupportPlanType: Standard
ProvisioningState: Succeeded 
```
This gets the provisioning state for the Standard support plan type. The provisioning state can be - Succeeded, Purchasing, Cancelling, Upgrading, Downgrading or Not Found.

### Get Standard support plan for a subscription which does not have a Standard support plan
```
PS C:\> Get-AzureRmAddon -SupportPlanType Standard
SupportPlanType: Standard
ProvisioningState: Not Found
```

### Check whether any support plan type is enabled for a subscription with a Standard support plan
```
PS C:\> Get-AzureRmAddon -SupportPlanType -All
SupportPlanType: Standard
Enabled: True

SupportPlanType: Advanced
Enabled: False

SupportPlanType: Essentials
Enabled: False
``` 

## PARAMETERS

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
Type: CanonicalSupportPlanTypesExtension
Parameter Sets: (All)
Aliases: 
Accepted values: Standard, Advanced, Essentials, All

Required: False
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

## INPUTS

### None


## OUTPUTS

### Microsoft.Azure.Commands.Addons.Models.PsSupportPlanResponse
System.Collections.Generic.List`1[[Microsoft.Azure.Commands.Addons.Models.PsCanonicalSupportPlanStatusItem, Microsoft.Azure.Commands.Addons, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]


## NOTES

## RELATED LINKS

