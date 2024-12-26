namespace MazeGame;

//Builder
public interface IMazeBuilder
{
    void AddRoom();
    void AddDoor();

    Maze Build();
}
