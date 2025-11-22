using System.Windows;
using WeatherApp.WPF.ViewModels;

namespace WeatherApp.WPF;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        DataContext = new WeatherViewModel();
    }
}