using CustomeHttpClientRequestBuilder;
using CustomeHttpClientRequestBuilder.Models;
using CustomHttpClientRequestBuilder;

IHttpRequestFactory requestFactory = new HttpRequestFactory();

var response = await requestFactory
    .PutAsync()
    .AddUri("uri")
    .AddBody("data")
    .AddToken(new Token("token", TypeOfToken.Bearer))
    .BuildAsync<object>();
Console.WriteLine();