
public interface ITable
{
}

public class MetalTable : ITable
{
    public override string ToString()
    {
        return $"metal table\n";
    }
}

public class WoodTable : ITable
{
    public override string ToString()
    {
        return $"wood table";
    }
}


