using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointRunpipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointRunpipeline.ServiceendpointRunpipelineAuthPersonal")]
    public class ServiceendpointRunpipelineAuthPersonal : azuredevops.ServiceendpointRunpipeline.IServiceendpointRunpipelineAuthPersonal
    {
        /// <summary>The Azure DevOps personal access token which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_runpipeline#personal_access_token ServiceendpointRunpipeline#personal_access_token}
        /// </remarks>
        [JsiiProperty(name: "personalAccessToken", typeJson: "{\"primitive\":\"string\"}")]
        public string PersonalAccessToken
        {
            get;
            set;
        }
    }
}
