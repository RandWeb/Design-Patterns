namespace Directory;

//composite
public class Directory : FileItem
{
    private List<FileItem> _items;

    public Directory()
    {
        _items = new List<FileItem>();
    }

    public Directory(params FileItem[] items)
    {
        _items = items.ToList();
    }

    public void AddFile(FileItem item)
    {
        _items.Add(item);
    }

    public override int Size()
    {
        int sum = 0;
        _items.ForEach(item => sum += item.Size());

        return sum;
    }
}

