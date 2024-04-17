
namespace CellRegistry;

public interface ICellRegistry
{
    Cell GetCellBySubscriptionId(String subscriptionId);
    Cell GetCellForCurrentSubscription();
}