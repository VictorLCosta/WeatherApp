using System.Collections.ObjectModel;
using WeatherApp.Infrastructure.ApiContracts.Responses;

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

}
