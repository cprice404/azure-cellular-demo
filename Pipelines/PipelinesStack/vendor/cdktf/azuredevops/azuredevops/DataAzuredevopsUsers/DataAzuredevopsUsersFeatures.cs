using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsUsers
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsUsers.DataAzuredevopsUsersFeatures")]
    public class DataAzuredevopsUsersFeatures : azuredevops.DataAzuredevopsUsers.IDataAzuredevopsUsersFeatures
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/users#concurrent_workers DataAzuredevopsUsers#concurrent_workers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "concurrentWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConcurrentWorkers
        {
            get;
            set;
        }
    }
}
