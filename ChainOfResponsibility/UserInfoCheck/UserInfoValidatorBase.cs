namespace ChainOfResponsibility.UserInfoCheck;

public abstract class UserInfoValidator(UserInfoValidator validator = null) : IHandler
{
    private readonly UserInfoValidator _validator = validator;
    public abstract Task<ResponseMessage> Handle(RequestMessage requestMessage);
}