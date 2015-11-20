using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_4
{
    class LCPrint:SomePrint
    {
        public string Print(string str)
        {
            str=str.ToLower();
            str = str.Replace(' ', '_');
            return str;
        }
    }
}
