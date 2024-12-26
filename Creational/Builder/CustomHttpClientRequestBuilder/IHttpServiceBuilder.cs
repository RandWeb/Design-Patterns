using CustomeHttpClientRequestBuilder.Models;

namespace CustomeHttpClientRequestBuilder;

public interface IHttpServiceBuilder : IBuilder
{
    public IHttpServiceBuilder AddUri(string Uri);
    public IHttpServiceBuilder AddBody<T>(T body);
    public IHttpServiceBuilder AddHeaders(Dictionary<string, string>? headers);
    public IHttpServiceBuilder AddToken(Token token);
}

public interface IBuilder
{
    Task<TResponse> BuildAsync<TResponse>();
}