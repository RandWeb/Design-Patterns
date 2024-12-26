namespace Media;
public abstract class MediaItem
{
    public virtual string Title { get; protected set; }

    public abstract void Play();

    public abstract bool IsPalying { get; set; }
    public abstract bool IsComposite { get; }
}

public class MediaFolder : MediaItem
{
    private List<MediaItem> _items;
    public override string Title { get => base.Title; protected set => base.Title = value; }
    public MediaFolder(string title)
    {
        this.Title = title;
        this._items = new List<MediaItem>();
    }

    public override bool IsComposite => true;

    public override bool IsPalying { get; set; }

    public void Add(MediaItem item) => _items.Add(item);

    public int Count() => _items.Count;

    public override void Play()
    {
        _items.ForEach(music =>
        {
            music.Play();
            music.IsPalying = true;
            //playing 
            //end
            music.IsPalying = false;
        });
    }

    public void Remove(MediaItem item) => _items.Remove(item);
}

public class Music : MediaItem
{
    public Music(string title)
    {
        Title = title;
    }

    public override string Title { get => base.Title; protected set => base.Title = value; }
    public override bool IsComposite => false;

    public override bool IsPalying { get; set; }

    public override void Play()
    {
        Console.WriteLine($"{Title} is palying");
    }

}