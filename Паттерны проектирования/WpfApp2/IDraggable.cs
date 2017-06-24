using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    public interface IDraggable
    {
        void CaptureMouse();

        void ReleaseMouseCapture();

        Point GetPosition(object arg);
    }
}
