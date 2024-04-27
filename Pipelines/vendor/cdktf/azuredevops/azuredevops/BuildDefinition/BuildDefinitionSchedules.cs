using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.buildDefinition.BuildDefinitionSchedules")]
    public class BuildDefinitionSchedules : azuredevops.BuildDefinition.IBuildDefinitionSchedules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#days_to_build BuildDefinition#days_to_build}.</summary>
        [JsiiProperty(name: "daysToBuild", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] DaysToBuild
        {
            get;
            set;
        }

        private object? _branchFilter;

        /// <summary>branch_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#branch_filter BuildDefinition#branch_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "branchFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionSchedulesBranchFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BranchFilter
        {
            get => _branchFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azuredevops.BuildDefinition.IBuildDefinitionSchedulesBranchFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BuildDefinition.IBuildDefinitionSchedulesBranchFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _branchFilter = value;
            }
        }

        private object? _scheduleOnlyWithChanges;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#schedule_only_with_changes BuildDefinition#schedule_only_with_changes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheduleOnlyWithChanges", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ScheduleOnlyWithChanges
        {
            get => _scheduleOnlyWithChanges;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scheduleOnlyWithChanges = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#start_hours BuildDefinition#start_hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartHours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#start_minutes BuildDefinition#start_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#time_zone BuildDefinition#time_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeZone
        {
            get;
            set;
        }
    }
}
