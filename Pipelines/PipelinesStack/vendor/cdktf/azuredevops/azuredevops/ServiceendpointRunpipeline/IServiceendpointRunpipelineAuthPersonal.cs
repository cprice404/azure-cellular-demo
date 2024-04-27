using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointRunpipeline
{
    [JsiiInterface(nativeType: typeof(IServiceendpointRunpipelineAuthPersonal), fullyQualifiedName: "azuredevops.serviceendpointRunpipeline.ServiceendpointRunpipelineAuthPersonal")]
    public interface IServiceendpointRunpipelineAuthPersonal
    {
        /// <summary>The Azure DevOps personal access token which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_runpipeline#personal_access_token ServiceendpointRunpipeline#personal_access_token}
        /// </remarks>
        [JsiiProperty(name: "personalAccessToken", typeJson: "{\"primitive\":\"string\"}")]
        string PersonalAccessToken
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointRunpipelineAuthPersonal), fullyQualifiedName: "azuredevops.serviceendpointRunpipeline.ServiceendpointRunpipelineAuthPersonal")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointRunpipeline.IServiceendpointRunpipelineAuthPersonal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Azure DevOps personal access token which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_runpipeline#personal_access_token ServiceendpointRunpipeline#personal_access_token}
            /// </remarks>
            [JsiiProperty(name: "personalAccessToken", typeJson: "{\"primitive\":\"string\"}")]
            public string PersonalAccessToken
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
