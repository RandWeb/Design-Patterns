public interface IChair
{
    
}

public class MetalChair : IChair
{
    public override string ToString()
    {
        return $"metal chair";
    }
}
public class WoodChair : IChair
{
    public override string ToString()
    {
        return $"wood chair";
    }
}