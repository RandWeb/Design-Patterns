namespace ChainOfResponsiblity.UserInfoCheck;

public record ResponseMessage(bool IsSuccess, string Message);

public record RequestMessage(string UserName, string Password);

public interface IHandler
{
    Task<ResponseMessage> Handle(RequestMessage requestMessage);
}

public abstract class UserInfoValidator(UserInfoValidator validator = null) : IHandler
{
    private readonly UserInfoValidator _validator = validator;
    public abstract Task<ResponseMessage> Handle(RequestMessage requestMessage);
}

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