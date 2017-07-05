using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class WizardState : IWizardState
    {
        protected readonly IStateable<IWizardState> stateHolder;

        protected WizardState(IStateable<IWizardState> stateHolder)
        {
            this.stateHolder = stateHolder;
        }

        #region Implementation of IWizard

        public virtual string Text { get; set; }

        public virtual void GoNext()
        {
            SetNextState(new LicenseConfirmationState(stateHolder));
        }

        public virtual void GoPrev()
        {
            throw new NotImplementedException();
        }

        public virtual void Cancel()
        {
            throw new NotImplementedException();
        }

        public virtual void Finish()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Implementation of IWizardState

        public virtual void Enter()
        {
        }

        public virtual void Exit()
        {
        }

        #endregion

        protected void SetNextState(IWizardState nextState)
        {
            stateHolder.SetNextState(nextState);   
        }
    }
}
