using cell_registry;

public class CellRegistry
{
    public static ICellRegistry Default()
    {
        return new HardCodedCellRegistry();
    }
}