namespace TreeProject.Legacy;

public class TreeFactory
{
    readonly Dictionary<string, ITree> _cache = new();

    public ITree this[string name, string color, string size]
    {
        get
        {
            ITree tree;
            string key = $"{name}_color_size";
            if (_cache.ContainsKey(key))
                tree = _cache[key];
            else
            {
                tree = new Tree(name, color, size);
                _cache.Add(key, tree);
            }

            return tree;
        }
    }
}