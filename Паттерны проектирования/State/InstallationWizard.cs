using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public sealed class InstallationWizard : IWizard, IStateable<IWizardState>
    {
        private IWizardState currentState;

        public InstallationWizard()
        {
            SetNextState(new WelcomeState(this));   
        }

        #region Implementation of IStateable<IWizard>

        public void SetNextState(IWizardState nextState)
        {
            currentState?.Exit();

            currentState = nextState;

            currentState.Enter();
        }

        #endregion

        #region Implementation of IWizard

        public string Text => currentState.Text;

        public void GoNext() => currentState.GoNext();

        public void GoPrev() => currentState.GoPrev();

        public void Cancel() => currentState.Cancel();

        public void Finish() => currentState.Finish();

        #endregion
    }
}
