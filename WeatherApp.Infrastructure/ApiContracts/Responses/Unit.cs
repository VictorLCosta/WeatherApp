namespace WeatherApp.Infrastructure.ApiContracts.Responses;

public class Units
{
    public int Value { get; set; }
    public string Unit { get; set; } = string.Empty;
    public int UnitType { get; set; }
}
