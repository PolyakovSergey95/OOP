using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_3
{
    class ENGreeter:IGreeter
    {
        public string SayHello()
        {
            Console.WriteLine("Hello");
            return "Hello";
        }
    }
}
