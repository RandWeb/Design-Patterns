namespace MazeGame;

//Director
public class MazeDirector
{
    private readonly IMazeBuilder _builder;

    public MazeDirector(IMazeBuilder builder)
    {
        _builder = builder;
    }

    public Maze LevelOne()
    {
        _builder.AddDoor();

        _builder.AddRoom();

        return _builder.Build();
    }
    public Maze LevelTwo()
    {
        // other values
        _builder.AddDoor();

        _builder.AddRoom();

        return _builder.Build();
    }
    ...
}