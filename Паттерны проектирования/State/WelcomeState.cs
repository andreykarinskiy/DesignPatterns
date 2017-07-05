using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public sealed class WelcomeState : WizardState
    {
        public WelcomeState(IStateable<IWizardState> stateHolder) : base(stateHolder)
        {
        }

        public override string Text { get; set; } = "Welcome!";

        public override void Cancel()
        {
            Console.WriteLine("Отмена инсталляции...");

            SetNextState(new CanceledState(stateHolder));
        }

        public override void Enter()
        {
            Console.WriteLine("Привет! Это суперинсталлятор для мегапрограммы.");
        }
    }
}
