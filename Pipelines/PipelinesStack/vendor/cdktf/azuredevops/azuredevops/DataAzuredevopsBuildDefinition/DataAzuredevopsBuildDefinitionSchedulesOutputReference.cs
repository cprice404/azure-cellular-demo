using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsBuildDefinition
{
    [JsiiClass(nativeType: typeof(azuredevops.DataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionSchedulesOutputReference), fullyQualifiedName: "azuredevops.dataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionSchedulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzuredevopsBuildDefinitionSchedulesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzuredevopsBuildDefinitionSchedulesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzuredevopsBuildDefinitionSchedulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzuredevopsBuildDefinitionSchedulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "branchFilter", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionSchedulesBranchFilterList\"}")]
        public virtual azuredevops.DataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionSchedulesBranchFilterList BranchFilter
        {
            get => GetInstanceProperty<azuredevops.DataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionSchedulesBranchFilterList>()!;
        }

        [JsiiProperty(name: "daysToBuild", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DaysToBuild
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "scheduleJobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduleJobId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduleOnlyWithChanges", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable ScheduleOnlyWithChanges
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "startHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartHours
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "startMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsBuildDefinition.DataAzuredevopsBuildDefinitionSchedules\"}", isOptional: true)]
        public virtual azuredevops.DataAzuredevopsBuildDefinition.IDataAzuredevopsBuildDefinitionSchedules? InternalValue
        {
            get => GetInstanceProperty<azuredevops.DataAzuredevopsBuildDefinition.IDataAzuredevopsBuildDefinitionSchedules?>();
            set => SetInstanceProperty(value);
        }
    }
}
