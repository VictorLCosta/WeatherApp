namespace WeatherApp.Infrastructure.ApiContracts.Responses;

public class City
{
    public int Version { get; set; }
    public string Key { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Rank { get; set; }
    public string LocalizedName { get; set; } = string.Empty;
    public Area Country { get; set; } = null!;
    public Area AdministrativeArea { get; set; } = null!;
}
