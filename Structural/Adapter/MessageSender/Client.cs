
public class Client
{
    private IMessager _messager;

    public Client(IMessager messager)
    {
        _messager = messager;
    }

    public void DoAnyThing()
    {
        var message = new Message()
        {
            Text = "",
            UserName = "",
        };
        _messager.SendMessage(message);
    }
}
