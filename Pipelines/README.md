# Azure Cell Architecture Demo: Pipelines

This directory contains example code to create an Azure Devops project, with pipelines for deploying each of the
application components to all the cells defined in our Cell Registry. It also contains a PipelineOfPipelines, which
iterates over all of the target cells and all of the application components, and keeps the individual application
component pipelines up to date.

Whenever you want to add or remove cells, you can update the Cell Registry and the [CellWaves.cs](https://github.com/cprice404/azure-cellular-demo/tree/main/application/Pipelines/PipelinesGenerator/CellWaves.cs)
file, then commit your changes, and the PipelineOfPipelines will update all of the other pipelines accordingly.

Whenever you want to add or remove application components, or change the definition of the build/deploy steps that should
be taken for a given pipeline component, you can update the [ApplicationComponents.cs](https://github.com/cprice404/azure-cellular-demo/tree/main/application/Pipelines/PipelinesGenerator/ApplicationComponents.cs)
file, then commit your changes, and the PipelineOfPipelines will update the pipelines accordingly.

NOTE: in this example code, the deployment stages (such as `BuildAndPushAcrImageStage`) are just wired up to use a
`CmdLine@2` azure pipeline task, and echo an informative message about what they would be doing. To actually deploy
the application components, you would modify the stage definitions in [ApplicationComponent.cs](https://github.com/cprice404/azure-cellular-demo/tree/main/application/Pipelines/PipelinesGenerator/ApplicationComponent.cs)
to either add the real CLI commands, or to wire them up to other [Azure Pipeline tasks](https://learn.microsoft.com/en-us/azure/devops/pipelines/tasks/reference/?view=azure-pipelines&viewFallbackFrom=azure-devops).
You can also add any other stages that you like!

# Initial Deployment

To deploy the Azure Devops project for the first time, first you'll need to do the following:

1. Create (or choose) a subscription that you want to use for your DevOps resources.
2. Create a service principal with `Owner` role (or, a lesser-privileged role that will suffice for what you need your
  pipelines to be able to deploy) in that subscription:
  `az ad sp create-for-rbac --name celldemo-devops --role Owner --scopes /subscriptions/<YOUR_SUBSCRIPTION_ID>`
  Make sure you save the appId, password, and tenant.
  ([More Info](https://learn.microsoft.com/en-us/azure/developer/terraform/authenticate-to-azure?tabs=bash#create-a-service-principal`))
3. Create an Azure storage account and container to use for the Terraform state. ([Example](https://learn.microsoft.com/en-us/azure/developer/terraform/store-state-in-azure-storage?tabs=azure-cli#2-configure-remote-state-storage-account))
4. If your source repo is on github (as in this example), you'll need to create a GitHub PAT with `repo` scope. 
5. If you don't have one already, create your azure devops organization.
  
  NOTE: When you are navigating from the Azure portal to Azure DevOps, make sure that you have chosen the Entra Id / Active Directory for
  your Azure tenant, and NOT 'Microsoft Account'; otherwise you won't be able to connect your service principal to your Azure DevOps:
  
  ![choose directory](./choose-devops-org.png)
  
6. In your Azure Devops Org, go to "Organization Settings", then "Users". Click "Add Users" and add the service principal
   that you created in step 2 above. Give it the "Stakeholder" role.
7. In your Azure Devops Org, go to "Organization Settings", then "Security->permissions". Click the "Users" tab, find your
   service principal, click the "Member of" tab, and add them to the "Project Collection Administrators" group.

Almost there!

Now we have all the pieces that we need in order to do our initial CDKTF deployment of the Azure Devops project.
Navigate to the `PipelinesStack` directory and run the following commands:

```bash
cd ./Pipelines/PipelinesStack
cp appsettings.json.EXAMPLE appsettings.json
export ARM_CLIENT_ID=<YOUR_SERVICE_PRINCIPAL_APP_ID>
export ARM_CLIENT_SECRET=<YOUR_SERVICE_PRINCIPAL_PASSWORD>
export ARM_TENANT_ID=<YOUR_SERVICE_PRINCIPAL_TENANT_ID>
export ARM_SUBSCRIPTION_ID=<YOUR_DEVOPS_SUBSCRIPTION_ID>
```

Then, edit the `appsettings.json` file and fill in the required fields:

* `CdkTfBackendAzureResourceGroupName`
* `CdkTfBackendAzureStorageAccountName`
* `CdkTfBackendAzureStorageContainerName`
* `AzureDevopsOrganizationUrl`
* `GithubPersonalAccessToken`

Finally, run the following commands to deploy the Azure Devops project:

```bash
dotnet build
npm run deploy
```

When the cdktf deploy command completes, you should have 4 pipelines in your new Azure Devops project:

![Pipelines](./new-pipelines.png)

Now we need to create a variable group that the pipelines will use for various configuration and auth. From the Pipelines
page, click "Library" in the left nav, then click "+ Variable Group" to add a Variable group. Name the variable group
`pipeline-config`, and add the following variables:

* `AzureDevOpsOrganizationUrl`
* `CdkTfBackendAzureResourceGroupName`
* `CdkTfBackendAzureStorageAccountName`
* `CdkTfBackendAzureStorageContainerName`
* `GithubPersonalAccessToken`
* `PipelineServicePrincipalAppId`
* `PipelineServicePrincipalPassword`
* `PipelineServicePrincipalTenantId`
* `PipelineSubscriptionId`

It should look something like this:

![Variable Group](./variable-group.png)

Make sure you click "Save" to save the variable group when you are done.

Finally, we need to authorize the project to access github. Click on the "PipelineOfPipelines" and click on
"Edit", and you should see a prompt to authorize github. Once you have done that, you should see the pipeline
definition (YAML). Click on the Run button to run the PipelineOfPipelines for the first time!

If you get an error message saying that "No hosted parallelism has been purchased or granted", you will need to
either follow the link in the message to request access to the free tier (may take a few days), or you can
increase the "paid parallel jobs" setting under "Organization"->"Billing". (It may take 30 minutes or more for the
paid parallel jobs to become available after you've changed the billing setting.)

# Trigger the pipelines

Each pipeline is now configured to trigger on a push to the `main` branch, if any files in the corresponding directory
have been modified. For example, try modifying the README in the `application/TimeService` directory and commiting;
you should see the `TimeService` pipeline trigger and run.

# Modify the pipeline



# Note on CDK for Terraform and Azure Devops provider






NOTES:
* need parallel builds on azure pipelines
* if doing npm install to get a fixed version of cdktf, need to update csproj to exclude nodemodules
* need an azure devops PAT
* need to install azure pipelines github app, and maybe cancel out when it starts trying to connect to a pipeline
* need to have a github PAT
* When you want to add a pipeline that needs azure permissions for a new subscription, you need to go to the azure devops console, then go to your project, project settings, "service connections" (under Pipelines tab), and add a service connection. Thankfully if you forget to do this, it will detect it at the time that it is parsing the YAML, and put up an error message on the pipeline screen..

* Need to create a variable group to populate appsettings.json; first run after that, you will have to approve permissions for it in the console
* Need to create a service principal because terraform won't work using azure CLI login via a user account
* SUPER IMPORTANT to use the right "directory" when setting stuff up in devops console so you can connect service principals
* Add the service principal as a user in azure devops org
* env var AZDO_PERSONAL_ACCESS_TOKEN for local deploy of POP?
