# Azure Web App Deployment Template

This repository contains an Azure Resource Manager (ARM) template for deploying a scalable and secure web application on Azure. The template provisions an Azure Web App, an App Service Plan, an Azure SQL Database, and an Azure SQL Server, providing a robust environment for hosting web applications.

## Resources Deployed

- **Azure App Service Plan**: A scalable hosting plan for the web app.
- **Azure Web App**: The web application itself, hosted in Azure.
- **Azure SQL Server**: A managed relational database service.
- **Azure SQL Database**: The database for storing application data.

## Prerequisites

Before deploying the template, ensure you have:

- An Azure subscription.
- Azure CLI installed on your machine.
- Logged into Azure CLI (`az login`).

## Parameters

The template uses the following parameters for customization:

- `webAppName`: Unique name for the Azure Web App.
- `appServicePlanName`: Name for the Azure App Service Plan.
- `sqlServerName`: Unique name for the Azure SQL Server.
- `sqlAdministratorLogin`: Administrator login name for SQL Server.
- `sqlAdministratorLoginPassword`: Secure password for the SQL Server administrator.
- `location`: Azure region for deploying the resources (defaults to the resource group's location).
- `sku`: Pricing tier for the App Service Plan (default is "F1").

## Deployment

To deploy the ARM template, follow these steps:

1. Clone this repository to your local machine.
2. Navigate to the repository directory.
3. Customize `azuredeploy.parameters.json` with your specific values.
4. Deploy the template using the Azure CLI:


Replace `<ResourceGroupName>` with the name of your Azure resource group.

## Outputs

After deployment, the template will output:

- `webAppUrl`: URL to access the deployed web application.
- `sqlServerFullyQualifiedDomainName`: FQDN of the deployed SQL Server.

## Security Considerations

- Treat the `sqlAdministratorLoginPassword` parameter securely.
- Consider using Azure Key Vault for managing secrets.
- Review and configure Azure SQL Database firewall rules as per your security requirements.

## Troubleshooting

- Ensure all resource names are unique and conform to Azure's naming requirements.
- Verify the specified Azure region supports all the resources being deployed.

## Contributing

Contributions to this template are welcome! Please read our [Contributing Guide](CONTRIBUTING.md) for more information.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
