using CustomeHttpClientRequestBuilder;
using CustomeHttpClientRequestBuilder.Models;

namespace CustomHttpClientRequestBuilder;

public class PutHttpClient : HttpRequestBase, IHttpServiceBuilder
{
    public PutHttpClient()
    {
        _request = new(HttpMethod.Put);
    }

    public IHttpServiceBuilder AddUri(string Uri)
    {
        _request.Uri = Uri;
        return this;
    }

    public IHttpServiceBuilder AddBody<T>(T body)
    {
        _request.Body = body;
        return this;
    }

    public IHttpServiceBuilder AddHeaders(Dictionary<string, string>? headers)
    {
        _request.Headers = headers;
        return this;
    }

    public IHttpServiceBuilder AddToken(Token token)
    {
        _request.Token = token;
        return this;
    }
}