namespace TreeProject;

public class TreeType : ITree
{
    public TreeType(string name, string color, string size)
    {
        Name = name;
        Color = color;
        Size = size;
    }

    public string Name { get; private set; }

    public string Color { get; private set; }

    public string Size { get; private set; }

    public void Draw(ITree tree)
    {
        var obj = (Tree)tree;

        Console.WriteLine($"TreeType : {GetHashCode()},{Name},Tree : ({obj.Coord_X},{obj.Coord_Y})");
    }
}
