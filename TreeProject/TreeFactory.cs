namespace TreeProject;

//Flyweight Factory
public class TreeFactory
{
    readonly Dictionary<string, TreeType> _cache = new();

    public TreeType this[string name, string color, string size]
    {
        get
        {
            TreeType tree;
            string key = $"{name}_color_size";
            if (_cache.ContainsKey(key))
                tree = _cache[key];
            else
            {
                tree = new TreeType(name, color, size);
                _cache.Add(key, tree);
            }

            return tree;
        }
    }
}