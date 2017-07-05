using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface IWizardState : IWizard
    {
        void Enter();

        void Exit();
    }
}
