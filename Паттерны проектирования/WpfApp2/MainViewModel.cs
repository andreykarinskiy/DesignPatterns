using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

        private IDraggable rect;

        public MainViewModel()
        {
            OnMouseLeftButtonDown = new DelegateCommand<IDraggable>(rect_MouseLeftButtonDown);
            OnMouseLeftButtonUp = new DelegateCommand(rect_MouseLeftButtonUp);
            OnMouseMove = new DelegateCommand<object>(rect_MouseMove);
        }

        public ICommand OnMouseLeftButtonDown { get; }

        public ICommand OnMouseLeftButtonUp { get; }

        public ICommand OnMouseMove { get; }

        private void rect_MouseLeftButtonDown(IDraggable rect)
        {
            this.rect = rect;

            isRectDragInProg = true;

            rect.CaptureMouse();
        }

        private void rect_MouseLeftButtonUp()
        {
            isRectDragInProg = false;
            rect.ReleaseMouseCapture();
        }

        private void rect_MouseMove(Point pt)
        {
            if (!isRectDragInProg || rect == null)
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
