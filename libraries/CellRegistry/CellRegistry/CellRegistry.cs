namespace CellRegistry;

public class CellRegistry
{
    public static ICellRegistry Default()
    {
        return new HardCodedCellRegistry();
    }
}