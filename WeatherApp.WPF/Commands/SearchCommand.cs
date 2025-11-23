using WeatherApp.Infrastructure.Api;
using WeatherApp.WPF.ViewModels;

namespace WeatherApp.WPF.Commands;

public class SearchCommand(WeatherViewModel weatherViewModel, AccuWeatherApiClient apiClient) : AsyncCommandBase
{
    public override bool CanExecute(object? parameter)
    {
        var query = parameter?.ToString();

        if (string.IsNullOrEmpty(query))
            return false;

        return base.CanExecute(parameter);
    }

    public override async Task ExecuteAsync(object? parameter)
    {
        var query = parameter?.ToString();

        var cities = await apiClient.GetCitiesAutoCompleteAsync(query!);
    }
}
