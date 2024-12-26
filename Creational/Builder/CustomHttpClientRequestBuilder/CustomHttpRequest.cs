using CustomeHttpClientRequestBuilder.Models;

namespace CustomeHttpClientRequestBuilder;

public class CustomHttpRequest(HttpMethod httpMethod)
{
    public HttpMethod HttpMethod { get; private set; } = httpMethod;
    public string Uri { get; set; }
    public object? Body { get; set; }
    public Dictionary<string, string>? Headers { get; set; }
    public Token? Token { get; set; }
}