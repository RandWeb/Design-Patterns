using Design.DependencyInjection.Weather.ConssoleApp;
using Design.DependencyInjection.Weather.ConssoleApp.Weather;
using Microsoft.Extensions.DependencyInjection;

if (args.Length == 0)
{
    args = new string[1];
    args[0] = "Gachasaran";
}

var services = new ServiceCollection();

services.AddSingleton<IWeatherService, OpenWeatherService>();
services.AddSingleton<Application>();

var serviceProvider = services.BuildServiceProvider();

var app = serviceProvider.GetService<Application>();
var application = serviceProvider.GetRequiredService<Application>();

await application.RunAsync(args);