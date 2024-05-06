namespace PipelinesGenerator;

public class ApplicationComponents
{
 
    /**
     * Here we define all of the components that make up our application. Each component has a name, a path from the root
     * of the repository, and a pipeline definition. The pipeline definition controls what happens in the build, release,
     * and deploy stages for each component.
     */
    public static List<ApplicationComponent> AllComponents = new()
    {
        /**
         * For example, this core infra app might just have a simple `make` target for its build, and no artifacts
         * to release during the release stage. Then it just uses CdkTf to deploy.
         */
        new ApplicationComponent("CoreInfrastructure", "application/Core", new ApplicationComponent.PipelineDefinition
        {
            BuildStage = Pipeline.Build.Make(),
            ReleaseStage = Pipeline.Release.Noop(),
            CellDeploySteps = new[]
            {
                Pipeline.CellDeploy.CdkTfDeploy()
            }
        }),
        /**
         * And this app has a `make` target for build, plus a push of an ACR image during release. Then during deployment
         * it may have a few k8s manifests to apply and a shell command to run.
         */
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
        /**
         * And this one has a `make` for build, an ACR push for release, and a CDKTF deploy for deployment.
         */
        new ApplicationComponent("HelloService", "application/HelloService",
            new ApplicationComponent.PipelineDefinition
            {
                BuildStage = Pipeline.Build.Make(),
                ReleaseStage = Pipeline.Release.BuildAndPushAcrImage(),
                CellDeploySteps = new[]
                {
                    Pipeline.CellDeploy.CdkTfDeploy()
                }
            }),
    };
    
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

        public record Bake
        {
            public static ApplicationComponent.PipelineBakeStage MonitorAlerts() => new ApplicationComponent.PipelineBakeStage.MonitorAlertsStage();
            
            private Bake() {}
        }

        private Pipeline() {}
    }
}