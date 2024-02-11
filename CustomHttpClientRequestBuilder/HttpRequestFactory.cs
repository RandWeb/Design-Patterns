﻿using CustomeHttpClientRequestBuilder;

namespace CustomHttpClientRequestBuilder;

public class HttpRequestFactory : IHttpRequestFactory
{
    public IHttpServiceBuilder CreateAsync<T>() where T : IHttpServiceBuilder, new()
    {
        var httpClient = new T();
        return httpClient;
    }
}