using System.Collections.ObjectModel;
using WeatherApp.Infrastructure.Api;
using WeatherApp.Infrastructure.ApiContracts.Responses;
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

        var cities = await apiClient.GetCitiesAutoCompleteAsync(query!) ?? [];

        weatherViewModel.CitiesList.Clear();

        foreach (var item in cities)
        {
            weatherViewModel.CitiesList.Add(item);
        }
    }
}
