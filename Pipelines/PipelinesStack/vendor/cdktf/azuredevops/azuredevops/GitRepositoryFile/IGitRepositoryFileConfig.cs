using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.GitRepositoryFile
{
    [JsiiInterface(nativeType: typeof(IGitRepositoryFileConfig), fullyQualifiedName: "azuredevops.gitRepositoryFile.GitRepositoryFileConfig")]
    public interface IGitRepositoryFileConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>The file's content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository_file#content GitRepositoryFile#content}
        /// </remarks>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>The file path to manage.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository_file#file GitRepositoryFile#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
        string File
        {
            get;
        }

        /// <summary>The repository ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository_file#repository_id GitRepositoryFile#repository_id}
        /// </remarks>
        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryId
        {
            get;
        }

        /// <summary>The branch name, defaults to "refs/heads/master".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository_file#branch GitRepositoryFile#branch}
        /// </remarks>
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Branch
        {
            get
            {
                return null;
            }
        }

        /// <summary>The commit message when creating or updating the file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository_file#commit_message GitRepositoryFile#commit_message}
        /// </remarks>
        [JsiiProperty(name: "commitMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CommitMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository_file#id GitRepositoryFile#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable overwriting existing files, defaults to "false".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository_file#overwrite_on_create GitRepositoryFile#overwrite_on_create}
        /// </remarks>
        [JsiiProperty(name: "overwriteOnCreate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OverwriteOnCreate
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository_file#timeouts GitRepositoryFile#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.gitRepositoryFile.GitRepositoryFileTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.GitRepositoryFile.IGitRepositoryFileTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGitRepositoryFileConfig), fullyQualifiedName: "azuredevops.gitRepositoryFile.GitRepositoryFileConfig")]
        internal sealed class _Proxy : DeputyBase, azuredevops.GitRepositoryFile.IGitRepositoryFileConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The file's content.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository_file#content GitRepositoryFile#content}
            /// </remarks>
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
            public string Content
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The file path to manage.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository_file#file GitRepositoryFile#file}
            /// </remarks>
            [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
            public string File
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The repository ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository_file#repository_id GitRepositoryFile#repository_id}
            /// </remarks>
            [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The branch name, defaults to "refs/heads/master".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository_file#branch GitRepositoryFile#branch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Branch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The commit message when creating or updating the file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository_file#commit_message GitRepositoryFile#commit_message}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "commitMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CommitMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository_file#id GitRepositoryFile#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enable overwriting existing files, defaults to "false".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository_file#overwrite_on_create GitRepositoryFile#overwrite_on_create}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overwriteOnCreate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? OverwriteOnCreate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository_file#timeouts GitRepositoryFile#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.gitRepositoryFile.GitRepositoryFileTimeouts\"}", isOptional: true)]
            public azuredevops.GitRepositoryFile.IGitRepositoryFileTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuredevops.GitRepositoryFile.IGitRepositoryFileTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
