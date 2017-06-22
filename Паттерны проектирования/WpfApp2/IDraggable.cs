using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public interface IDraggable
    {
        void CaptureMouse();

        void ReleaseMouseCapture();
    }
}
