using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EL400Analyzer_v02.Model
{
    public class logBase : DependencyObject
    {
        public enum logType { Object, Cabinet, Text };

        public DateTime Date
        {
            get;
            set;
        }
        public logType Type
        {
            get;
            set;
        }
        public logBase(DateTime date)
        {
            this.Date = date;
        }
    }
}
