namespace MazeGame;

//Concrete Class
public class StandardMazeBuilder : IMazeBuilder
{
    private Maze _maze;

    public StandardMazeBuilder()
    {
        _maze = new Maze();
    }

    public void AddDoor()
    {
        _maze.Door = "Standard Door";
    }

    public void AddRoom()
    {
        _maze.Room = "Standard Room";
    }

    public Maze Build()
    {
        return _maze;
    }
}
