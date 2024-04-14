using Constructs;
using HashiCorp.Cdktf;
using azuredevops.Project;


namespace MyCompany.MyApp
{
    class MainStack : TerraformStack
    {
        public MainStack(Construct scope, string id) : base(scope, id)
        {
            var projectConfig = new ProjectConfig();
            projectConfig.Name = "myCdkTfProject";
            var project = new Project(scope, "myproject", projectConfig);
        }
    }
}