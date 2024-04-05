namespace ChainOfResponsibility.UserInfoCheck;

public class CheckUserNameAndPassword(UserInfoValidator validator = null) : UserInfoValidator(validator)
{
    public async override Task<ResponseMessage> Handle(RequestMessage requestMessage)
    {
        if (validator is null && requestMessage.Password.StartsWith("123456") &&
            requestMessage.UserName.StartsWith("m"))
            return new ResponseMessage(true, "username and password is valid");
        if (validator is not null && requestMessage.Password.StartsWith("123456") &&
            requestMessage.UserName.StartsWith("m"))
            return await validator.Handle(requestMessage);
        return new ResponseMessage(false, "username and password is invalid");
    }
}