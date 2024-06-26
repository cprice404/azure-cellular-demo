using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsBuildDefinition
{
    [JsiiClass(nativeType: typeof(azuredevops.DataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionRepositoryOutputReference), fullyQualifiedName: "azuredevops.dataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionRepositoryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzuredevopsBuildDefinitionRepositoryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzuredevopsBuildDefinitionRepositoryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzuredevopsBuildDefinitionRepositoryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzuredevopsBuildDefinitionRepositoryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "branchName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BranchName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "githubEnterpriseUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GithubEnterpriseUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "repoId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepoId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reportBuildStatus", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable ReportBuildStatus
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "repoType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepoType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceConnectionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ymlPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string YmlPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionRepository\"}", isOptional: true)]
        public virtual azuredevops.DataAzuredevopsBuildDefinition.IDataAzuredevopsBuildDefinitionRepository? InternalValue
        {
            get => GetInstanceProperty<azuredevops.DataAzuredevopsBuildDefinition.IDataAzuredevopsBuildDefinitionRepository?>();
            set => SetInstanceProperty(value);
        }
    }
}
