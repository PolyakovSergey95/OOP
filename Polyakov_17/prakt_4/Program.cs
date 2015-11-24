using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_4
{
    class Program
    {
        static void Main(string[] args)
        {
            StringPrinter printer = new StringPrinter(new UCPrint());
            Console.WriteLine(printer.Print());
            printer.Sp = new NCPrint();
            Console.WriteLine(printer.Print());
            printer.Sp = new LCPrint();
            Console.WriteLine(printer.Print());
            Water SomeWater=new Water(new LiquidWater());
            SomeWater.TempUP();
            SomeWater.TempUP();
            SomeWater.TempDown();
            SomeWater.TempDown();
            SomeWater.TempDown();
            Console.ReadLine();
        }
    }
}
