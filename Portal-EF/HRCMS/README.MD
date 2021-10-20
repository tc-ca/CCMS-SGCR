# HRCMS
# Sample appSettings.json
```ruby
{
    "Logging": {
        "LogLevel": {
            "Default": "Information",
            "Microsoft": "Warning",
            "Microsoft.Hosting.Lifetime": "Information"
        }
    },
    "GoCWebTemplate": {
        "version": "v4_0_32", 
        "environment": "Prod_SSL" 
    },
    "AllowedHosts": "*",
    "HrApi": {
        "ResourceUrl": "your authentication url",
        "appToken": "PhoenixForm"
    },
    "Dynamics": {
        "ResourceUrl": "https://your.crm.environment.dynamics.com",
        "ApiVersion": "9.1",
        "ClientId": "",
        "TenantId": "",
        "ClientSecret": "",
        "AuthContextUrl": "https://login.microsoftonline.com/"
    },
    "FileSizeLimit": 10485760
}
```
