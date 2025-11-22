using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace WeatherApp.Infrastructure.Api;

internal static class Extensions
{
    internal static IHostBuilder AddApi(this IHostBuilder host)
    {
        host.ConfigureServices((context, services) =>
        {
            var apiKey = context.Configuration.GetValue<string>("API_KEY");

            services.AddHttpClient<AccuWeatherApiClient>(c =>
            {
                c.DefaultRequestHeaders.Add("Authorization", apiKey);

                c.BaseAddress = new Uri("https://dataservice.accuweather.com");
            });
        });

        return host;
    }
}
