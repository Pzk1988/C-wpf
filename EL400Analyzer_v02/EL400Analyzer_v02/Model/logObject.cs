using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL400Analyzer_v02.Model
{
    class logObject : logBase
    {
        public List<byte> Objects
        {
            get;
            set;
        }

        public logObject(DateTime Date) : base(Date)
        {
            this.Type = logType.Object;
            this.Date = Date;
            this.Objects = new List<byte>();
            for(int i = 0; i < 20; i++)
            {
                this.Objects.Add((byte)i);
            }
        }
    }
}
