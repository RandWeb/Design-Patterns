namespace ChainOfResponsibility.UserInfoCheck;

public class CheckPassword(UserInfoValidator validator = null) : UserInfoValidator(validator)
{
    public override async Task<ResponseMessage> Handle(RequestMessage requestMessage)
    {
        if (validator is null && requestMessage.Password.StartsWith("123"))
            return new ResponseMessage(true, "password is valid");
        if (validator is not null && requestMessage.Password.StartsWith("123"))
            return await validator.Handle(requestMessage);
        return new ResponseMessage(false, "password is invalid");
    }
}