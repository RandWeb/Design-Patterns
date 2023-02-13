namespace Directory;

//leaf
public class File : FileItem
{
    private readonly int _size;
    public File(int size)
    {
        _size = size;
    }


    public override int Size()
    {
        return _size;
    }
}

