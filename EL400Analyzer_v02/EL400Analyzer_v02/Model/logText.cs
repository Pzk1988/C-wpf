using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL400Analyzer_v02.Model
{
    class logText : logBase
    {
        public string Text
        {
            get;
            set;
        }

        public logText(DateTime Date) : base(Date)
        {
            this.Type = logType.Text;
            this.Text = "Zacznie to wkoncu kurwa działać?";
        }
    }
}
