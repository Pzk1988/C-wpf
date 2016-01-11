using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace EL400Analyzer_v02.Converters
{
    class ObjectStateToHexString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (targetType != typeof(List<byte>))
            {
                List<byte> myList = value as List<byte>;
                return BitConverter.ToString(myList.GetRange(3, myList.Count - 3).ToArray());
            }
            else
            {
                throw new InvalidOperationException("Obkiet docelowy musi byc typu eLogType");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ByteToHexString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (targetType != typeof(byte))
            {
                return ((Byte)value).ToString("X").PadLeft(2, '0');
            }
            else
            {
                throw new InvalidOperationException("Obkiet docelowy musi byc typu eLogType");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
