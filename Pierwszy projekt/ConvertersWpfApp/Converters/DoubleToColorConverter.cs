﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ConvertersWpfApp.Converters
{
    public class DoubleToColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Color color;
            if (values != null 
                && values.Length == 3
                    )
            { 
                byte red = System.Convert.ToByte((double)values[0]);
                byte green = System.Convert.ToByte((double)values[0]);
                byte blue = System.Convert.ToByte((double)values[0]);
                color = Color.FromRgb(red, green, blue);
                return new SolidColorBrush(color);

                
            }
            color = Color.FromRgb(0, 0, 0);
            return new SolidColorBrush(color);

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}