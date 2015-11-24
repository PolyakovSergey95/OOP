using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace prakt_4
{
    class LiquidWater:IState
    {
        public event StateHandler NextState;
        public void TempDown()
        {
            Console.WriteLine("Устанавливаем температуру ниже нуля градусов или равной нулю градусов...");
            Thread.Sleep(1500);
            Console.WriteLine("Лёд!");
            if (NextState != null)
                NextState(new SolidWater());
        }
        public void TempUP()
        {
            Console.WriteLine("Устанавливаем температуру больше ста градусов или равную ста градусам...");
            Thread.Sleep(1500);
            Console.WriteLine("Пар!");
            if (NextState != null)
                NextState(new GasWater());
        }
    }
}
