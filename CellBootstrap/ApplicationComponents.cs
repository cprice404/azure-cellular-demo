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
            // This controls the order in which the components are deployed. The order is reversed for teardown.
            new ApplicationComponent("application/Core"),
            new ApplicationComponent("application/TimeService"),
            new ApplicationComponent("application/HelloService")
        };
    }
}