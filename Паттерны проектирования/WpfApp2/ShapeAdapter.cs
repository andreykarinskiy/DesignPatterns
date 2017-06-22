using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace WpfApp2
{
    public sealed class DraggableAdapter : IDraggable
    {
        private readonly Shape adaptee;

        public DraggableAdapter(Shape adaptee)
        {
            this.adaptee = adaptee;
        }

        public DraggableAdapter(object adaptee) : this((Shape)adaptee)
        {
        }

        public void CaptureMouse()
        {
            adaptee.CaptureMouse();
        }

        public void ReleaseMouseCapture()
        {
            adaptee.ReleaseMouseCapture();
        }
    }
}
