namespace TreeProject.Legacy;

//Concrete FlyWight
public class Tree : ITree
{
    public Tree(string name, string color, string size)
    {
        Name = name;
        Color = color;
        Size = size;
    }

    public Tree(string name, string color, string size, int coord_X, int coord_Y)
    {
        Name = name;
        Color = color;
        Size = size;
        Coord_X = coord_X;
        Coord_Y = coord_Y;
    }

    public string Name { get; private set; }
    public string Color { get; private set; }
    public string Size { get; private set; }

    //Unshared Concrete Flywight
    public int Coord_X { get; private set; }

    //Unshared Concrete Flywight
    public int Coord_Y { get; private set; }

    public void SetCoord(int x, int y)
    {
        Coord_X = x;
        Coord_Y = y;
    }
}
