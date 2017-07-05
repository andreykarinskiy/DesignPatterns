using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public sealed class CanceledState : WizardState
    {
        public CanceledState(IStateable<IWizardState> stateHolder) : base(stateHolder)
        {
        }

        public override string Text { get; set; } = "Canceled";

        public override void Enter()
        {
            Console.WriteLine("Очистка временных файлов и завершение работы");
        }
    }
}
