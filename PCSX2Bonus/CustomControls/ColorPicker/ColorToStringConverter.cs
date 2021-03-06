﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace PCSX2Bonus.CustomControls.ColorPicker
{
	[ValueConversion(typeof(Color), typeof(string))]
    public sealed class ColorToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var colorToSeek = (Color) value;
            return ColorNames.GetColorName(colorToSeek);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

