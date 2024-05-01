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
            public static ApplicationComponent.PipelineCellDeployStep CdkTfDeploy() => new ApplicationComponent.PipelineCellDeployStep.CdkTfDeployStep();
            public static ApplicationComponent.PipelineCellDeployStep AksApplyManifest(String manifestPath) => new ApplicationComponent.PipelineCellDeployStep.AksApplyManifestStep(manifestPath);
            public static ApplicationComponent.PipelineCellDeployStep ShellCmd(String displayName, String shellCommand) => new ApplicationComponent.PipelineCellDeployStep.ShellCommandStep(displayName, shellCommand);
            
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
            CellDeploySteps = new[]
            {
                Pipeline.CellDeploy.CdkTfDeploy()
            }
        }),
        new ApplicationComponent("TimeService", "application/TimeService", new ApplicationComponent.PipelineDefinition
        {
            BuildStage = Pipeline.Build.Make(),
            ReleaseStage = Pipeline.Release.BuildAndPushAcrImage(),
            CellDeploySteps = new[]
            {
                Pipeline.CellDeploy.AksApplyManifest("application/TimeService/k8s/deployment.yml"),
                Pipeline.CellDeploy.AksApplyManifest("application/TimeService/k8s/service.yml"),
                Pipeline.CellDeploy.ShellCmd("Store AppConfig", "application/TimeService/scripts/store-loadbalancer-address-to-appconfig.sh"),
            }
        }),
        new ApplicationComponent("HelloService", "application/HelloService", new ApplicationComponent.PipelineDefinition
        {
            BuildStage = Pipeline.Build.Make(),
            ReleaseStage = Pipeline.Release.BuildAndPushAcrImage(),
            CellDeploySteps = new[]
            {
                Pipeline.CellDeploy.CdkTfDeploy()
            }
        }),
    };
}