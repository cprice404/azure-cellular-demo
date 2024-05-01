
namespace CellRegistry;

public interface ICellRegistry
{
    Cell GetCellBySubscriptionId(String subscriptionId);
    Cell GetCellForCurrentSubscription();
    Cell GetCellByName(String cellName);
    string CoreInfrastructureResourceGroupName { get; }
}