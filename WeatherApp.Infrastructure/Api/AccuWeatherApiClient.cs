using System.Net.Http;
using System.Net.Http.Json;
using WeatherApp.Infrastructure.ApiContracts.Responses;

namespace WeatherApp.Infrastructure.Api;

public class AccuWeatherApiClient(HttpClient client)
{
    public async Task<CurrrentCondition?> GetCurrrentConditionAsync(string locationKey)
    {
        var currrentConditions = 
            await client.GetFromJsonAsync<List<CurrrentCondition>>($"/currentconditions/v1/{locationKey}");

        return currrentConditions?[0];
    }

    public async Task<List<City>?> GetCitiesAutoCompleteAsync(string query)
    {
        var cities = 
            await client.GetFromJsonAsync<List<City>>($"/locations/v1/cities/autocomplete?q={query}");

        return cities;
    }
}
