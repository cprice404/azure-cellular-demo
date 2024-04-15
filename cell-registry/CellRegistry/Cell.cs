namespace cell_registry;

public enum CellType
{
    DEVELOPER,
    PREPROD,
    PROD
}
public record struct Cell(String subscriptionId, String cellName, CellType cellType);