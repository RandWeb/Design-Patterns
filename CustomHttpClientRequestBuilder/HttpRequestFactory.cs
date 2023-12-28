using CustomeHttpClientRequestBuilder;

namespace CustomHttpClientRequestBuilder;

public class HttpRequestFactory : IHttpRequestFactory
{

    public IHttpServiceBuilder PostAsync()
    {
      return new PutHttpClient();
    }

    public IHttpServiceBuilder PutAsync()
    {
        return new PutHttpClient();
    }

    public IHttpServiceBuilder GetAsync()
    {
        return new PutHttpClient();
    }
}