using cell_registry;
using Xunit.Abstractions;

namespace CellRegistryTest;

public class CellRegistryTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public CellRegistryTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void GetCellBySubscriptionId_ReturnsDeveloperChrisCell()
    {
        var developerChrisSubscriptionId = "5cf20061-1947-49d1-915b-4c0345485985";
        ICellRegistry registry = CellRegistry.Default();
        Assert.Equal(
            registry.GetCellBySubscriptionId(developerChrisSubscriptionId),
            new Cell(
                subscriptionId: developerChrisSubscriptionId,
                cellName: "developer-chris",
                cellType: CellType.DEVELOPER
            )
        );
    }
}