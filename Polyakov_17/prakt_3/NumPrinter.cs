using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace prakt_3
{
    class NumPrinter
    {
        private int n;
        public NumPrinter(int n)
        {
            this.n = n;
        }

        public int[] GetNumbers()
        {
            Thread.Sleep(10000);
            int[] Numbers = new int[n];
            for (int i=0;i<n;i++)
            {
                Numbers[i] = i;
            }
            return Numbers;
        }
    }
}
