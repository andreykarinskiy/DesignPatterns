using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop
{
    public abstract class Command
    {
        public abstract void Execute(CanvasPresenter presenter);

        public abstract void Unexecute(CanvasPresenter presenter);
    }
}
