namespace PipelinesGenerator;

public class ApplicationComponents
{
    public record Pipeline
    {
        public record Build
        {
            public static ApplicationComponent.PipelineBuildStage Make() => new ApplicationComponent.PipelineBuildStage.MakeStage();
            
            private Build() {}
        }
        
        public record Release
        {
            public static ApplicationComponent.PipelineReleaseStage Noop() => new ApplicationComponent.PipelineReleaseStage.NoopStage();
            
            public static ApplicationComponent.PipelineReleaseStage BuildAndPushAcrImage() => new ApplicationComponent.PipelineReleaseStage.BuildAndPushAcrImageStage();
            
            private Release() {}
        }

        public record CellDeploy
        {
            public static ApplicationComponent.PipelineCellDeployStage CdkTfDeploy() => new ApplicationComponent.PipelineCellDeployStage.CdkTfDeployStage();
            public static ApplicationComponent.PipelineCellDeployStage AksApplyManifest(String manifestPath) => new ApplicationComponent.PipelineCellDeployStage.AksApplyManifestStage(manifestPath);
            public static ApplicationComponent.PipelineCellDeployStage ShellCmd(String shellCommand) => new ApplicationComponent.PipelineCellDeployStage.ShellCommandStage(shellCommand);
            
            private CellDeploy() {}
        }

        private Pipeline() {}
    }
    
    public static List<ApplicationComponent> AllComponents = new()
    {
        new ApplicationComponent("CoreInfrastructure", "application/Core", new ApplicationComponent.PipelineDefinition
        {
            BuildStage = Pipeline.Build.Make(),
            ReleaseStage = Pipeline.Release.Noop(),
            CellDeployStages = new[]
            {
                Pipeline.CellDeploy.CdkTfDeploy()
            }
        }),
        new ApplicationComponent("TimeService", "application/TimeService", new ApplicationComponent.PipelineDefinition
        {
            BuildStage = Pipeline.Build.Make(),
            ReleaseStage = Pipeline.Release.BuildAndPushAcrImage(),
            CellDeployStages = new[]
            {
                Pipeline.CellDeploy.AksApplyManifest("application/TimeService/k8s/deployment.yml"),
                Pipeline.CellDeploy.AksApplyManifest("application/TimeService/k8s/service.yml"),
                Pipeline.CellDeploy.ShellCmd("application/TimeService/scripts/store-loadbalancer-address-to-appconfig.sh"),
            }
        }),
        new ApplicationComponent("HelloService", "application/HelloService", new ApplicationComponent.PipelineDefinition
        {
            BuildStage = Pipeline.Build.Make(),
            ReleaseStage = Pipeline.Release.BuildAndPushAcrImage(),
            CellDeployStages = new[]
            {
                Pipeline.CellDeploy.CdkTfDeploy()
            }
        }),
    };
}