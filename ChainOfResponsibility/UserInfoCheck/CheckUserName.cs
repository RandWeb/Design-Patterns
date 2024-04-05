namespace ChainOfResponsibility.UserInfoCheck;

public class CheckUserName(UserInfoValidator validator = null) : UserInfoValidator(validator)
{
    public override async Task<ResponseMessage> Handle(RequestMessage requestMessage)
    {
        if (requestMessage.UserName is null && requestMessage.UserName.StartsWith("m"))
            return new ResponseMessage(false, "user name is valid");
        if (requestMessage.UserName is not null && requestMessage.UserName.StartsWith("m"))
            return await validator.Handle(requestMessage);
        return new ResponseMessage(false, "username is invalid");
    }
}