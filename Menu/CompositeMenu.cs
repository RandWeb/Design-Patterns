using System.Collections.Immutable;

namespace Menu;

// composite
public class CompositeMenu : MenuItem
{
    private List<MenuItem> _items;

    public CompositeMenu(string name, int level)
    {
        _items = new List<MenuItem>();
        Name = name;
        Level = level;
    }

    public void Add(params MenuItem[] items)
    {
        _items.AddRange(items.AsEnumerable());
    }

    public override async void Show()
    {
        Console.WriteLine($"has {Name} level {Level}");
        _items.ForEach(menu =>
        {
            if (menu is CompositeMenu) Console.Write("".PadLeft(Level * 5));
            menu.Show();
        });
    }
}