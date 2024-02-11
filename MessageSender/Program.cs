// See https://aka.ms/new-console-template for more information
Console.Write("");
public class Message
{
    public string Text { get; set; }
    public string UserName { get; set; }
}

public interface IMessager
{
    void SendMessage(Message message);
}

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

public class SmsManager:IMessager
{
    public void SendSms(string text,string phoneNumber)
    {
        
    }

    public void SendMessage(Message message)
    {

    }
}

public class EmailService
{
    public bool SendEmail(string jsonInfo)
    {
        return true;
    }
}