using WeatherApp.Infrastructure.Api;
using WeatherApp.Infrastructure.ApiContracts.Responses;
using WeatherApp.WPF.ViewModels;

namespace WeatherApp.WPF.Commands;

public class GetCurrentConditionCommand(WeatherViewModel weatherViewModel, AccuWeatherApiClient apiClient) : AsyncCommandBase
{
    public override async Task ExecuteAsync(object? parameter)
    {
        var city = parameter as City;
        if (city == null)
        {
            weatherViewModel.CurrrentCondition = null;
            return;
        }

        var currentCondition = await apiClient.GetCurrrentConditionAsync(city!.Key);

        if (currentCondition != null) 
        {
            weatherViewModel.CurrrentCondition = currentCondition;
        }
    }
}
