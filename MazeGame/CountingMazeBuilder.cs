namespace MazeGame;

//Concrete Class
public class CountingMazeBuilder : IMazeBuilder
{
    private Maze _maze;

    public CountingMazeBuilder()
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
