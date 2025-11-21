namespace WeatherApp.Infrastructure.ApiContracts.Responses;

public class Temperature
{
    public Units Metric { get; set; } = null!;
    public Units Imperial { get; set; } = null!;
}
