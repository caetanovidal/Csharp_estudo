using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace wpf005_MVVM.ViewModel.ValueConverter
{
    class EnumToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isRaining = (bool) value;

            if (isRaining)
                return @"C:\Users\Windows\estudos\WPF\wpf005-MVVM-WeatherApp\rainIcon.jpg";

            return @"C:\Users\Windows\estudos\WPF\wpf005-MVVM-WeatherApp\SunIcon.jpg";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
