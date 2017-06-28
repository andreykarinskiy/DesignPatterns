using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop
{
    public interface ICanvasView
    {
        event EventHandler Adding;

        bool IsCanUndo { get; set; }

        bool IsCanRedo { get; set; }

        IDraggable CreateShape(int x, int y);

        void Remove(IDraggable shape);
    }
}
