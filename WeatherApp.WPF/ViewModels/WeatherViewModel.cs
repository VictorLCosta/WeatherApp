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
        }
    }

    private ObservableCollection<CurrrentCondition> currrentConditions = [];

    public ObservableCollection<CurrrentCondition> CurrrentConditions
    {
        get { return currrentConditions; }
        set
        {
            currrentConditions = value;
            OnPropertyChanged(nameof(CurrrentConditions));
        }
    }

    public ICommand SearchCities { get; set; }

    public WeatherViewModel(AccuWeatherApiClient apiClient)
    {
        SearchCities = new SearchCommand(this, apiClient);
    }

}
