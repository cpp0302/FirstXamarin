using Cirrious.CrossCore.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value.Core.Converters
{
	public class StringLengthValueConverter : MvxValueConverter<string, int>
	{
		protected override int Convert(string value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			value = value ?? "";
			return value.Length;
		}
	}
}
