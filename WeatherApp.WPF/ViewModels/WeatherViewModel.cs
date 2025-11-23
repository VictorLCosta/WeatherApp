using System.Collections.ObjectModel;
using System.Windows.Input;
using WeatherApp.Infrastructure.Api;
using WeatherApp.Infrastructure.ApiContracts.Responses;
using WeatherApp.WPF.Commands;

namespace WeatherApp.WPF.ViewModels;

public class WeatherViewModel : ViewModelBase
{
    private string _query = string.Empty;

    public string Query
    {
        get { return _query; }
        set { 
            _query = value;
            OnPropertyChanged(nameof(Query));
        }
    }

    private City? _selectedCity;

    public City? SelectedCity
    {
        get { return _selectedCity; }
        set
        {
            _selectedCity = value;
            OnPropertyChanged(nameof(SelectedCity));
            GetCurrentCondition.Execute(_selectedCity);
        }
    }

    private CurrrentCondition? _currrentCondition;

    public CurrrentCondition? CurrrentCondition
    {
        get { return _currrentCondition; }
        set
        {
            _currrentCondition = value;
            OnPropertyChanged(nameof(CurrrentCondition));
        }
    }

    public ObservableCollection<City> CitiesList { get; set; } = [];

    public ICommand SearchCities { get; set; }
    public ICommand GetCurrentCondition { get; set; }

    public WeatherViewModel(AccuWeatherApiClient apiClient)
    {
        SearchCities = new SearchCommand(this, apiClient);
        GetCurrentCondition = new GetCurrentConditionCommand(this, apiClient);
    }

}
