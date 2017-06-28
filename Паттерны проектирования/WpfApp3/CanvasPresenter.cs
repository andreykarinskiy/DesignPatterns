using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public sealed class CanvasPresenter
    {
        private readonly ICanvasView view;

        public CanvasPresenter(ICanvasView view)
        {
            this.view = view;
        }

        public void Initialize()
        {
            ((IShellView)view).SetCanRedo(false);
            ((IShellView)view).SetCanUndo(false);

            var rnd = new Random();
            for (var i = 0; i < 10; i++)
            {
                view.AddShape(rnd.Next(400), rnd.Next(200));
            }
        }
    }
}
