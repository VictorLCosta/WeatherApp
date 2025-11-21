namespace WeatherApp.Infrastructure.ApiContracts.Responses;

public class CurrrentCondition
{
    public DateTime LocalObservationDateTime { get; set; }
    public int EpochTime { get; set; }
    public string WeatherText { get; set; } = string.Empty;
    public int WeatherIcon { get; set; }
    public bool HasPrecipitation { get; set; }
    public object PrecipitationType { get; set; }
    public bool IsDayTime { get; set; }
    public Temperature Temperature { get; set; } = null!;
    public string MobileLink { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
}
