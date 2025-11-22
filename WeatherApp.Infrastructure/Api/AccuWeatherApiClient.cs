using System.Net.Http;
using System.Net.Http.Json;
using WeatherApp.Infrastructure.ApiContracts.Responses;

namespace WeatherApp.Infrastructure.Api;

public class AccuWeatherApiClient(HttpClient client)
{
    public async Task<List<CurrrentCondition>?> GetCurrrentConditionAsync(string locationKey)
    {
        List<CurrrentCondition>? currrentConditions = 
            await client.GetFromJsonAsync<List<CurrrentCondition>>($"/currentconditions/v1/{locationKey}");

        return currrentConditions;
    }
}
