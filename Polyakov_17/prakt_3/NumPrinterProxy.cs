using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_3
{
    class NumPrinterProxy
    {
        NumPrinter ONumPrinter;
        int[] Nums;
        public NumPrinterProxy(int n)
        {
            ONumPrinter = new NumPrinter(n);
            Nums = new int[n];
            Nums = ONumPrinter.GetNumbers();
        }
        public int[] GetNumbers()
        {
            int[] Numbers = new int[Nums.GetLength(0) / 2];
            for (int i = 0; i < Nums.GetLength(0) / 2; i++)
            {
                Numbers[i] = Nums[i * 2+1];
            }
                return Numbers;
        }
    }
}
