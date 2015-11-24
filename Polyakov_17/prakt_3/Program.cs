using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_3
{
    class Program
    {
        static void Main(string[] args)
        {
            NumPrinterProxy Npp = new NumPrinterProxy(20);
            int[] Nums = Npp.GetNumbers();
            for (int i = 0; i < Nums.Length; i++)
            {
                Console.WriteLine(Nums[i].ToString());
            }
        }

    }
}
