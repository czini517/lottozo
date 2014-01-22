﻿using System;
using System.Windows;
using System.Windows.Data;

namespace LottozoCore.Converters
{
	public class BoolToVisibilityNegateConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return (bool)value ? Visibility.Collapsed : Visibility.Visible;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return ((Visibility)value != Visibility.Visible);
		}
	}
}
