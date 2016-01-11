using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL400Analyzer_v02.Model
{
    class logCabinet : logBase
    {
        public int CabinetID
        {
            get;
            set;
        }
        public List<byte> InputCards
        {
            get;
            set;
        }
        public List<byte> OutputCards
        {
            get;
            set;
        }
        public List<virtualInput> VirtualInputs
        { 
            get;
            set;
        }
        public List<virtualOutput> VirtualOutputs
        {
            get;
            set;
        }  
        public logCabinet(DateTime Data) : base(Data)
        {
            Random rnd = new Random();
            CabinetID = rnd.Next(1, 6);
            this.Type = logType.Cabinet;
            InputCards = new List<byte>() {0x01, 0x02, 0x03, 0x04, 0x05, 0x06};
            OutputCards = new List<byte>() {0x07, 0x08, 0x09, 0x0A};
            VirtualInputs = new List<virtualInput>() {new virtualInput(1), new virtualInput(2), new virtualInput(3), new virtualInput(4)};
            VirtualOutputs = new List<virtualOutput>() { new virtualOutput(7), new virtualOutput(8), new virtualOutput(9), new virtualOutput(10) };
        }
    }


    class virtualInput
    {
        public int ID
        {
            get;
            set;
        }
        public bool State
        {
            get;
            set;
        }
        public bool OCC
        {
            get;
            set;
        }
        public virtualInput(int ID)
        {
            this.ID = ID;
            this.State = (this.ID % 2 == 0 ? true : false);
            this.OCC = (this.ID % 3 == 0 ? true : false);
        }
    }

    class virtualOutput
    {
        public int ID
        {
            get;
            set;
        }
        public bool State
        {
            get;
            set;
        }
        public bool OCC
        {
            get;
            set;
        }
        public virtualOutput(int ID)
        {
            this.ID = ID;
            this.State = (this.ID % 2 == 0 ? true : false);
            this.OCC = (this.ID % 3 == 0 ? true : false);
        }
    }
}
