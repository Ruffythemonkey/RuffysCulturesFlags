using Microsoft.UI.Xaml.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Core;

namespace RuffysCulturesFlags.Converter
{
    internal class IntToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null) return null;
            int x = (int)value;
            string twoletter = CultureInfo.GetCultureInfo(x).TwoLetterISOLanguageName;

            return MediaSource.CreateFromUri(new($"RuffysCulturesFlags/Images/{twoletter}.png", UriKind.Relative));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
