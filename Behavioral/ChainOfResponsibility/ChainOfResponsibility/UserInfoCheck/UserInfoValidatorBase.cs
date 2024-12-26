namespace Behavioral.ChainOfResponsibility.CheckUsers.UserInfoCheck;

public abstract class UserInfoValidatorBase(UserInfoValidatorBase validatorBase = null) : IHandler
{
    private readonly UserInfoValidatorBase _validatorBase = validatorBase;
    public abstract Task<ResponseMessage> HandleAsync(RequestMessage requestMessage);

}