using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WeatherApp.WPF.ViewModels;

namespace WeatherApp.WPF;

internal static class Extensions
{
    internal static IHostBuilder AddViewModels(this IHostBuilder host)
    {
        host.ConfigureServices(services =>
        {
            services.AddTransient<WeatherViewModel>();
        });

        return host;
    }

    internal static IHostBuilder AddViews(this IHostBuilder host)
    {
        host.ConfigureServices(services =>
        {
            services.AddSingleton(s => new MainWindow(s.GetRequiredService<WeatherViewModel>()));
        });

        return host;
    }
}
