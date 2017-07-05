using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public sealed class CopyingFilesState : WizardState
    {
        public CopyingFilesState(IStateable<IWizardState> stateHolder) : base(stateHolder)
        {
        }

        public override string Text { get; set; } = "Copying Files";

        public override void Enter()
        {
            Console.WriteLine("Запуск копирования файлов");
        }

        public override void Exit()
        {
            Console.WriteLine("Удаление временных файлов");
        }

        public override void Cancel()
        {
            SetNextState(new CanceledState(stateHolder));
        }
    }
}
