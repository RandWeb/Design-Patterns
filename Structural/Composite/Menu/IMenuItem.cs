namespace Menu;

//leaf
public abstract class MenuItem
{
    public string Name { get; set; }
    public int Level { get; set; }

    public abstract void Show();
}
