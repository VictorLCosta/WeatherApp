using System.ComponentModel;

namespace WeatherApp.WPF.ViewModels;

public delegate TViewModel CreateViewModel<TViewModel>() where TViewModel : ViewModelBase;

public abstract class ViewModelBase : INotifyPropertyChanged
{
    public virtual void Dispose() { }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName) 
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
