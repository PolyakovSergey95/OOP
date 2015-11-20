using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_4
{
    public class NCPrint:SomePrint
    {
        public string Print(string str)
        {
            str=str.Replace(' ', '_');
            return str;
        }
    }
}
