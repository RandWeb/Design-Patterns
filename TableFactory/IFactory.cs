public interface IFactory
{
    ITable CreateTable();
    IChair CreateChair();
}

public class CarpenterFactory : IFactory
{
    public ITable CreateTable()
    {
        return new WoodTable();
    } 

    public IChair CreateChair()
    {
        return new WoodChair();
    }
}

public class MetalFactory : IFactory
{
    public ITable CreateTable()
    {
        return new MetalTable();
    }

    public IChair CreateChair()
    {
        return new MetalChair();
    }
}