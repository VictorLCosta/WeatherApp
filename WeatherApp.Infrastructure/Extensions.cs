using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using WeatherApp.Infrastructure.Api;

namespace WeatherApp.Infrastructure;

public static class Extensions
{
    public static IHostBuilder AddInfrastructure(this IHostBuilder host) => host
        .AddConfiguration()
        .AddApi();

    private static IHostBuilder AddConfiguration(this IHostBuilder host)
    {
        host.ConfigureAppConfiguration(c =>
        {
            c.AddJsonFile("appsettings.json");
            c.AddEnvironmentVariables();
        });

        return host;
    }
}
