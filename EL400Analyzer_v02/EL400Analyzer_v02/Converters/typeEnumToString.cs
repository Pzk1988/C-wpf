using System;
using System.Globalization;
using System.Windows.Data;
using EL400Analyzer_v02.Model;

namespace EL400Analyzer_v02.Converters
{
    class typeEnumToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if(targetType != typeof(logBase.logType))
            {
                switch((logBase.logType)value)
                {
                    case logBase.logType.Cabinet:
                        {
                            return "Cabinet";
                        }
                    case logBase.logType.Text:
                        {
                            return "Text";
                        }
                    case logBase.logType.Object:
                        {
                            return "Objects";
                        }
                    default:
                        {
                            return "Nieznany typ";
                        }
                }
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
