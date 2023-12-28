namespace CustomeHttpClientRequestBuilder.Exceptions;

public class BadRequestException(string? message = "400") : Exception(message)
{
}