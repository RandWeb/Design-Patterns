namespace CustomeHttpClientRequestBuilder.Exceptions;

public class UnauthorizedException(string? message = "توکن درخواست دهنده سرویس منقضی شده است.") : Exception(message)
{
}