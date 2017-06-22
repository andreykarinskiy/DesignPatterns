using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

using Microsoft.Expression.Interactivity.Core;

using Prism.Commands;

namespace WpfApp2
{
    public class MainViewModel
    {
        private bool isRectDragInProg;

        public MainViewModel()
        {
            OnMouseLeftButtonDown = new DelegateCommand<IDraggable>(rect_MouseLeftButtonDown);
            OnMouseLeftButtonUp = new DelegateCommand<IDraggable>(rect_MouseLeftButtonUp);
            OnMouseMove = new DelegateCommand<IDraggable>(rect_MouseMove);
        }

        public ICommand OnMouseLeftButtonDown { get; }

        public ICommand OnMouseLeftButtonUp { get; }

        public ICommand OnMouseMove { get; }

        private void rect_MouseLeftButtonDown(IDraggable rect)
        {
            isRectDragInProg = true;
            rect.CaptureMouse();
        }

        private void rect_MouseLeftButtonUp(IDraggable rect)
        {
            isRectDragInProg = false;
            rect.ReleaseMouseCapture();
        }

        private void rect_MouseMove(IDraggable rect)
        {
            if (!isRectDragInProg)
            {
                return;
            }

            //var mousePos = e.GetPosition(canvas);

            //double left = mousePos.X - (rect.ActualWidth / 2);
            //double top = mousePos.Y - (rect.ActualHeight / 2);
            //Canvas.SetLeft(rect, left);
            //Canvas.SetTop(rect, top);
        }
    }
}
