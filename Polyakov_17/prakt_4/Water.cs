using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_4
{
    class Water
    {
        public IState state;
        public Water(IState SomeState)
        {
            OnNextState(SomeState);
        }
        private void OnNextState(IState SomeState)
        {
            if (SomeState == null)
                throw new ArgumentNullException("state");

            if (state == SomeState) return;

            state = SomeState;
            state.NextState += OnNextState;
            Console.WriteLine("Событие:");
        }
        public void TempUP()
        {
            state.TempUP();
        }
        public void TempDown()
        {
            state.TempDown();
        }
    }
}
