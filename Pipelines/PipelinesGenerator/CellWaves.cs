using CellRegistry;

public record CellWave(
    List<Cell> Cells
);

public record CellWaves
{
    public static List<CellWave> AllWaves()
    {
        var cellRegistry = CellRegistry.CellRegistry.Default();
        
        return new List<CellWave>
        {
            new(
                new List<Cell>()
                {
                    cellRegistry.GetCellByName("alpha")
                }
            ),
            new(
                new List<Cell>()
                {
                    cellRegistry.GetCellByName("westus3-1"),
                    cellRegistry.GetCellByName("southcentralus-1")
                }
            ),
            new(
                new List<Cell>()
                {
                    cellRegistry.GetCellByName("westus2-1"),
                    cellRegistry.GetCellByName("eastus1-1")
                }
            )
        };
    }
}