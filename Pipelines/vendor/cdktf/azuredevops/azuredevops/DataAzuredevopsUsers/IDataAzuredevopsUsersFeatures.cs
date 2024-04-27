using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsUsers
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsUsersFeatures), fullyQualifiedName: "azuredevops.dataAzuredevopsUsers.DataAzuredevopsUsersFeatures")]
    public interface IDataAzuredevopsUsersFeatures
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/users#concurrent_workers DataAzuredevopsUsers#concurrent_workers}.</summary>
        [JsiiProperty(name: "concurrentWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConcurrentWorkers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsUsersFeatures), fullyQualifiedName: "azuredevops.dataAzuredevopsUsers.DataAzuredevopsUsersFeatures")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsUsers.IDataAzuredevopsUsersFeatures
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/users#concurrent_workers DataAzuredevopsUsers#concurrent_workers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "concurrentWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConcurrentWorkers
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
