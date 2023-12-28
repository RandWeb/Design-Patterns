using CustomHttpClientRequestBuilder;

namespace CustomeHttpClientRequestBuilder;

//Builder
public interface IHttpRequestFactory
{
    IHttpServiceBuilder PostAsync();
    IHttpServiceBuilder PutAsync();
    IHttpServiceBuilder GetAsync();
}