namespace cell_registry;

public interface ICellRegistry
{
    Cell GetCellBySubscriptionId(String subscriptionId);
    Cell GetCellForCurrentSubscription();
}