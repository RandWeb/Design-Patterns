namespace Behavioral.ChainOfResponsibility.CheckUsers.UserInfoCheck;
/// <summary>
/// Concrete Handler
/// </summary>
public class CheckUserNameAndPassword(UserInfoValidatorBase validatorBase = null) : UserInfoValidatorBase(validatorBase)
{
    public async override Task<ResponseMessage> HandleAsync(RequestMessage requestMessage)
    {
        if (validatorBase is null && requestMessage.Password.StartsWith("123456") &&
            requestMessage.UserName.StartsWith("m"))
            return new ResponseMessage(true, "username and password is valid");
        if (validatorBase is not null && requestMessage.Password.StartsWith("123456") &&
            requestMessage.UserName.StartsWith("m"))
            return await validatorBase.HandleAsync(requestMessage);
        return new ResponseMessage(false, "username and password is invalid");
    }
}