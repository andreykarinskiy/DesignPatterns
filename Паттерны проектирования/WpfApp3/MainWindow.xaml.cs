using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ICanvasView, IShellView
    {
        private bool isRectDragInProg;

        private FrameworkElement element;

        public MainWindow()
        {
            // TODO: Перенести в контейнер!
            Presenter = new CanvasPresenter(this);

            InitializeComponent();

            Presenter.Initialize();
        }

        public CanvasPresenter Presenter { get; set; }

        public void AddShape(int x, int y)
        {
            var shape = new Ellipse
            {
                Width = 30,
                Height = 30,
                Fill = Brushes.Blue
            };

            shape.MouseLeftButtonDown += rect_MouseLeftButtonDown;
            shape.MouseLeftButtonUp += rect_MouseLeftButtonUp;
            shape.MouseMove += rect_MouseMove;

            Canvas.SetLeft(shape, x);
            Canvas.SetTop(shape, y);

            canvas.Children.Add(shape);
        }

        private void rect_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            element = (FrameworkElement)sender;

            isRectDragInProg = true;
            element.CaptureMouse();
        }

        private void rect_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isRectDragInProg = false;
            element.ReleaseMouseCapture();
        }

        private void rect_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isRectDragInProg) return;

            var parent = ((FrameworkElement)sender).Parent;
            var mousePos = e.GetPosition((IInputElement)parent);

            double left = mousePos.X - element.ActualWidth / 2;
            double top = mousePos.Y - element.ActualHeight / 2;

            Canvas.SetLeft(element, left);
            Canvas.SetTop(element, top);
        }

        public void SetCanUndo(bool state)
        {
            btnUndo.IsEnabled = state;
        }

        public void SetCanRedo(bool state)
        {
            btnRedo.IsEnabled = state;
        }
    }
}
