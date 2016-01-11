using System.Windows;
using System.Windows.Controls;
using EL400Analyzer_v02.Model;

namespace EL400Analyzer_v02.Selectors
{
    class LogTempletSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement elemnt = container as FrameworkElement;

            if (item is logCabinet)
            {
                return elemnt.FindResource("CabinetLogTemplate") as DataTemplate;
            }
            else if(item is logText)
            {
                return elemnt.FindResource("TextLogTemplate") as DataTemplate;
            }
            else if(item is logObject)
            {
                return elemnt.FindResource("ObjectLogTemplate") as DataTemplate;
            }
            else
            {
                return elemnt.FindResource("ErrorTemplate") as DataTemplate;
            }
        }
    }
}
