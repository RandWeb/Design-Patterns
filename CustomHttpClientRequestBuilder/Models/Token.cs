namespace CustomeHttpClientRequestBuilder.Models;

public class Token(string accessToken, TypeOfToken typeOfToken)
{
    public string AccessToken { get; init; } = accessToken;

    public TypeOfToken TypeOfToken { get; init; } = typeOfToken;
}

public enum TypeOfToken
{
    Bearer,
    Cookie
}