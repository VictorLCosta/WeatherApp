using System.Globalization;
using System.Windows.Data;

namespace WeatherApp.WPF.ValueConverters;

public class BoolToRainConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        bool isRaining = (bool)value;

        if (isRaining)
            return "Currently raining";
        else
            return "Not Raining at all";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        string isRaining = value.ToString()!;

        if (isRaining == "Currently raining")
            return true;

        return false;
    }
}
