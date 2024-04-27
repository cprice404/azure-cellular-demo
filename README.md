# azure-cellular-demo

NOTES:
* need parallel builds on azure pipelines
* building with .net8 will cause a bunch of warnings? stick with .net 6?
* if doing npm install to get a fixed version of cdktf, need to update csproj to exclude nodemodules
* need an azure devops PAT
* need to install azure pipelines github app, and maybe cancel out when it starts trying to connect to a pipeline
* need to have a github PAT
* Need to create an azure storage account for backend:
  * must enable storage service for subscription first
  * https://learn.microsoft.com/en-us/azure/developer/terraform/store-state-in-azure-storage?tabs=azure-cli

* When you want to add a pipeline that needs azure permissions for a new subscription, you need to go to the azure devops console, then go to your project, project settings, "service connections" (under Pipelines tab), and add a service connection.

