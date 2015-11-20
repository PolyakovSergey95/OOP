using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_3
{
    class PrinterAdapter:IGreeter
    {
        public string SayHello()
        {
            Printer OPrinter = new Printer();
            OPrinter.Print("Hallo");
            return "Hallo";
        }
    }
}
