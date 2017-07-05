using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface IStateable<in TState>
    {
        void SetNextState(TState nextState);
    }
}
