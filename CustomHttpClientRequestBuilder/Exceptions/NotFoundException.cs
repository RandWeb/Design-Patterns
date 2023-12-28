namespace CustomeHttpClientRequestBuilder.Exceptions;

public class NotFoundException(string? message = "اطلاعات مورد نظر پیدا نشد.") : Exception(message)
{
}