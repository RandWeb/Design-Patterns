namespace Menu;

// component
public class Menu : MenuItem
{
    public Menu(string name, int level)
    {
        this.Name = name;
        this.Level = level;
    }

    public override void Show()
    {
        Console.Write("".PadLeft(Level * 5));
        Console.WriteLine($"{Name} Exists in  Level {Level}");
    }
}
