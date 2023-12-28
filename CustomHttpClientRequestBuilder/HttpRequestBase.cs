using System.Net;
using System.Net.Http.Formatting;
using CustomeHttpClientRequestBuilder;
using CustomeHttpClientRequestBuilder.Exceptions;
using CustomeHttpClientRequestBuilder.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace CustomHttpClientRequestBuilder;

public abstract class HttpRequestBase : IBuilder
{
    protected readonly HttpClient _client;
    protected CustomHttpRequest _request;

    protected HttpRequestBase()
    {
        _client = new HttpClient();
    }

    public Task<TResponse> BuildAsync<TResponse>()
    {
        HttpRequestMessage request = new(_request.HttpMethod, _request.Uri)
        {
            Content = new ObjectContent<object>(
                _request.Body,
                new JsonMediaTypeFormatter
                {
                    SerializerSettings = new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    }
                })
        };

        SetHeaders(request, _request.Headers);

        SetToken(request, _request.Token);

        return GetResponse<TResponse>(request);
    }

    private void SetHeaders(HttpRequestMessage request, Dictionary<string, string>? headers)
    {
        if (headers is null) return;

        foreach (var header in headers)
            request.Headers.Add(header.Key, header.Value);
    }

    private void SetToken(HttpRequestMessage request, Token? token)
    {
        if (token is null) return;

        if (token.TypeOfToken is TypeOfToken.Cookie)
            request.Headers.TryAddWithoutValidation("Cookie", $"{token.TypeOfToken}={token.AccessToken}");

        if (token.TypeOfToken is TypeOfToken.Bearer)
            request.Headers.TryAddWithoutValidation("Authorization",
                $"{token.TypeOfToken} {token.AccessToken}");
    }

    private async Task<MemoryStream> GetResponseAsync(HttpRequestMessage request)
    {
        var task = await _client.SendAsync(request);
        HandlerCommonException(task);
        var content = await task.Content.ReadAsByteArrayAsync();
        MemoryStream stream = new(content);

        return stream;
    }

    private async Task<TResponse> GetResponse<TResponse>(HttpRequestMessage request)
    {
        var task = await _client.SendAsync(request);

        HandlerCommonException(task);

        var response = await task.Content.ReadAsStringAsync();

        if (task.IsSuccessStatusCode)
            return JsonConvert.DeserializeObject<TResponse>(response, new IsoDateTimeConverter());

        throw new BadRequestException(JObject.Parse(response).Value<string>("message"));
    }

    private void HandlerCommonException(HttpResponseMessage task)
    {
        if (task.StatusCode is HttpStatusCode.Unauthorized)
            throw new UnauthorizedException();
        if (task.StatusCode is HttpStatusCode.NotFound)
            throw new NotFoundException();
    }
}