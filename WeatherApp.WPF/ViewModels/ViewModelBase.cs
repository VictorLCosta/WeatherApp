using System.ComponentModel;

namespace WeatherApp.WPF.ViewModels;

internal abstract class ViewModelBase : INotifyPropertyChanged
{
    public virtual void Dispose() { }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName) 
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
