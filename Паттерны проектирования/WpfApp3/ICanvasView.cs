using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public interface ICanvasView
    {
        CanvasPresenter Presenter { get; set; }

        void AddShape(int x, int y);
    }
}
