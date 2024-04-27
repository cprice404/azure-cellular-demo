using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointExternaltfs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointExternaltfs.ServiceendpointExternaltfsAuthPersonal")]
    public class ServiceendpointExternaltfsAuthPersonal : azuredevops.ServiceendpointExternaltfs.IServiceendpointExternaltfsAuthPersonal
    {
        /// <summary>Personal access tokens are applicable only for connections targeting Azure DevOps organization or TFS 2017 (and higher).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_externaltfs#personal_access_token ServiceendpointExternaltfs#personal_access_token}
        /// </remarks>
        [JsiiProperty(name: "personalAccessToken", typeJson: "{\"primitive\":\"string\"}")]
        public string PersonalAccessToken
        {
            get;
            set;
        }
    }
}
