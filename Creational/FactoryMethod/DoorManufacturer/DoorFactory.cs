namespace DoorManufacturer;

//Factory | Creator
public class DoorFactory<T> where T : IDoor, new()
{
    public void CreateDoor()
    {
        var door = GetDoor();
        door.Design();
        door.Coloring();
        door.Build();
    }

    private T GetDoor()
    {
        return new T();
    }
}

