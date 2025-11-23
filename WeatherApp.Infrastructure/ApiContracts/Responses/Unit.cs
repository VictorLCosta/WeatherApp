namespace WeatherApp.Infrastructure.ApiContracts.Responses;

public class Units
{
    public double Value { get; set; }
    public string Unit { get; set; } = string.Empty;
    public int UnitType { get; set; }
}
