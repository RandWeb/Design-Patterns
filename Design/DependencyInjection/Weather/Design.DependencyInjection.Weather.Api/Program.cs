
using Design.DependencyInjection.Weather.Api.Filters;
using Design.DependencyInjection.Weather.Api.Services;
using Design.DependencyInjection.Weather.Api.Weather;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

{

    services.AddControllers();
    services.AddEndpointsApiExplorer();


    services.AddHttpClient();

    services.AddTransient<IWeatherService, OpenWeatherService>();
    services.AddScoped<LifeTimeIndicatorFilter>();
    services.AddScoped<IdGeneratorService>();
}



var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


await app.RunAsync();