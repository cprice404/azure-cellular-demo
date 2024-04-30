public record struct ApplicationComponent(
    String PipelineName,
    String Directory
);

public class ApplicationComponents
{
    public static List<ApplicationComponent> AllComponents = new()
    {
        new ApplicationComponent("CoreInfrastructure", "application/Core"),
        new ApplicationComponent("TimeService", "application/TimeService"),
        new ApplicationComponent("HelloService", "application/HelloService"),
    };
}