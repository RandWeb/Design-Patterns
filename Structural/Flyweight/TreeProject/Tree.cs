namespace TreeProject;

//Concrete FlyWight
public class Tree : ITree
{
    public Tree(TreeType type, int coord_X, int coord_Y)
    {
        Type = type;
        Coord_X = coord_X;
        Coord_Y = coord_Y;
    }

    public TreeType Type { get; private set; }

    //Unshared Concrete Flywight
    public int Coord_X { get; private set; }

    //Unshared Concrete Flywight
    public int Coord_Y { get; private set; }

    public void Draw(ITree tree) => Type.Draw(tree);
}
