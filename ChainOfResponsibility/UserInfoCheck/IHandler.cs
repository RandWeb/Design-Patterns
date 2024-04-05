namespace Behavioral.ChainOfResponsibility.CheckUsers.UserInfoCheck;

/// <summary>
/// handler
/// </summary>
public interface IHandler
{
    Task<ResponseMessage> HandleAsync(RequestMessage requestMessage);
}