using CustomeHttpClientRequestBuilder;
using CustomeHttpClientRequestBuilder.Models;

IHttpRequestFactory requestFactory = new HttpRequestFactory();

var response = await requestFactory
    .CreateAsync<PutHttpClient>()
    .AddUri("uri")
    .AddBody("data")
    .AddToken(new Token("token", TypeOfToken.Bearer))
    .BuildAsync<object>();
Console.WriteLine();