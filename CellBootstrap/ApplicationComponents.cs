namespace CellBootstrap;

public record struct ApplicationComponent(
    string PathFromRoot
);

public class ApplicationComponents
{
    public static List<ApplicationComponent> GetAllComponents()
    {
        return new List<ApplicationComponent>()
        {
            new ApplicationComponent("application/Core"),
            new ApplicationComponent("application/TimeService"),
            new ApplicationComponent("application/HelloService")
        };
    }
}