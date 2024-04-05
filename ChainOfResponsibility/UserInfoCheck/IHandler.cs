namespace ChainOfResponsibility.UserInfoCheck;

public interface IHandler
{
    Task<ResponseMessage> Handle(RequestMessage requestMessage);
}