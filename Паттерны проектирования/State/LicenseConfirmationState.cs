using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public sealed class LicenseConfirmationState : WizardState
    {
        private bool userConfirm;

        public LicenseConfirmationState(IStateable<IWizardState> stateHolder) : base(stateHolder)
        {
        }

        public override string Text { get; set; } = "License";

        public override void GoNext()
        {
            if (userConfirm)
            {
                SetNextState(new CopyingFilesState(stateHolder));
            }
        }

        public override void GoPrev()
        {
            Console.WriteLine("Возврат к предыдущей странице");

            SetNextState(new WelcomeState(stateHolder));
        }

        public override void Enter()
        {
            Console.WriteLine("Согласитесь с условиями?");

            userConfirm = true;
        }
    }
}
