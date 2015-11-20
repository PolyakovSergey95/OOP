using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_4
{
    class UCPrint:SomePrint
    {
        public string Print(string str)
        {
            str=str.ToUpper();
            str = str.Replace(' ', '_');
            return str;
        }
    }
}
