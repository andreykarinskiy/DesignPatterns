using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop
{
    public sealed class CreateShapeCommand : Command
    {
        private int x;
        private int y;

        public CreateShapeCommand(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override void Execute(CanvasPresenter presenter)
        {
            
        }

        public override void Unexecute(CanvasPresenter presenter)
        {
        }
    }
}
