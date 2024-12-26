using Newtonsoft.Json;

namespace MessageSender;

//inheritance Adapter
public class Adapter :EmailService ,IMessager
{
    public void SendMessage(Message message)
    {
        SendEmail(JsonConvert.SerializeObject(message));
    }
}

public class ObjectAdapter(EmailService emailService) : IMessager
{
    public void SendMessage(Message message)
    {
        emailService.SendEmail(JsonConvert.SerializeObject(message));
    }
}