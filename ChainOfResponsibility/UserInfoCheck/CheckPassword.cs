namespace Behavioral.ChainOfResponsibility.CheckUsers.UserInfoCheck;

/// <summary>
/// Concrete Handler
/// </summary>
public class CheckPassword(UserInfoValidatorBase validatorBase = null) : UserInfoValidatorBase(validatorBase)
{
    public override async Task<ResponseMessage> HandleAsync(RequestMessage requestMessage)
    {
        if (validatorBase is null && requestMessage.Password.StartsWith("123"))
            return new ResponseMessage(true, "password is valid");
        if (validatorBase is not null && requestMessage.Password.StartsWith("123"))
            return await validatorBase.HandleAsync(requestMessage);
        return new ResponseMessage(false, "password is invalid");
    }
}