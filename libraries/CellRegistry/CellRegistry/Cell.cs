namespace CellRegistry;

public enum CellType
{
    DEVELOPER,
    PREPROD,
    PROD
}
public record struct Cell(
    String SubscriptionId,
    String CellName,
    CellType CellType,
    AzureBackendStorageContainer BackendStorageContainer
);