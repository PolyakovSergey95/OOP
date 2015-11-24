using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace prakt_4
{
    class GasWater:IState
    {
        public event StateHandler NextState;
        public void TempDown()
        {
            Console.WriteLine("Устанавливаем температуру меньше ста градусов, но больше нуля градусов...");
            Thread.Sleep(1500);
            Console.WriteLine("Вода!");
            if (NextState != null)
                NextState(new LiquidWater());
        }
        public void TempUP()
        {
            Console.WriteLine("Нагреваем...");
            Thread.Sleep(1500);
            Console.WriteLine("Ничего не изменилось. Всё еще пар.");
        }
    }
}
