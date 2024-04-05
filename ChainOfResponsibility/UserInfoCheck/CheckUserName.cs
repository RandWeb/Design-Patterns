namespace Behavioral.ChainOfResponsibility.CheckUsers.UserInfoCheck;

/// <summary>
/// Concrete Handler
/// </summary>
public class CheckUserName(UserInfoValidatorBase validatorBase = null) : UserInfoValidatorBase(validatorBase)
{
    public override async Task<ResponseMessage> HandleAsync(RequestMessage requestMessage)
    {
        if (requestMessage.UserName is null && requestMessage.UserName.StartsWith("m"))
            return new ResponseMessage(false, "user name is valid");
        if (requestMessage.UserName is not null && requestMessage.UserName.StartsWith("m"))
            return await validatorBase.HandleAsync(requestMessage);
        return new ResponseMessage(false, "username is invalid");
    }
}

