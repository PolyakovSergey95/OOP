using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace prakt_4
{
    class SolidWater:IState
    {
        public event StateHandler NextState;
        public void TempDown()
        {
            Console.WriteLine("Охлаждаем...");
            Thread.Sleep(1500);
            Console.WriteLine("Ничего не изменилось. Всё еще лёд...");
        }
        public void TempUP()
        {
            Console.WriteLine("Устанавливаем температуру больше 0 градусов, но меньше 100 градусов...");
            Thread.Sleep(1500);
            Console.WriteLine("Вода!");
            if (NextState != null)
                NextState(new LiquidWater());
        }
    }
}
