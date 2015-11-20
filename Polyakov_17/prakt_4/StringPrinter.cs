using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_4
{
    class StringPrinter
    {
        public SomePrint Sp { private get; set; }
        public StringPrinter(SomePrint Sp)
        {
            this.Sp = Sp;
        }
        public string Print()
        {
            return Sp.Print("The quick brown fox jumps over the lazy dog.");
        }
    }
}
