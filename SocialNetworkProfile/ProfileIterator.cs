// See https://aka.ms/new-console-template for more information




/// <summary>
/// iterator
/// </summary>
public abstract class ProfileIterator
{
    protected int _currentPosition;
    protected Profile[] _profiles;
    public virtual Profile First()
    {
        _currentPosition = 0;
        return _profiles[_currentPosition];
    }

    public virtual Profile Last()
    {
        _currentPosition = _profiles.Length - 1;
        return _profiles[_currentPosition];
    }

    public virtual Profile Previous => _profiles[--_currentPosition];
    public virtual Profile Next => _profiles[_currentPosition++];

    public virtual bool HasNext => _currentPosition < _profiles.Length;

    public virtual bool IsFirst => _currentPosition is 0;
}

