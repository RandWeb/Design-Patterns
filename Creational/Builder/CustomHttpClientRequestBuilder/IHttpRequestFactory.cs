namespace CustomeHttpClientRequestBuilder;

//Builder
public interface IHttpRequestFactory
{
    IHttpServiceBuilder CreateAsync<T>()where T : IHttpServiceBuilder, new();
}