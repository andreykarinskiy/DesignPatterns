using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop
{
    public interface IDraggable
    {
        int X { get; }

        int Y { get; }

        void MoveTo(int x, int y);
    }
}
