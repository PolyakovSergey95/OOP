using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_4
{
    public delegate void StateHandler(IState state);

    public interface IState
    {
        event StateHandler NextState;
        void TempUP();
        void TempDown();
    }
}
