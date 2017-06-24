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
    public partial class MainWindow : Window
    {
        private bool isRectDragInProg;

        private FrameworkElement element;

        public MainWindow()
        {
            InitializeComponent();

            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                var shape = new Ellipse();
                shape.Width = 30;
                shape.Height = 30;
                shape.Fill = Brushes.Blue;
                shape.MouseLeftButtonDown += rect_MouseLeftButtonDown;
                shape.MouseLeftButtonUp += rect_MouseLeftButtonUp;
                shape.MouseMove += rect_MouseMove;

                Canvas.SetLeft(shape, rnd.Next(0, 500));
                Canvas.SetTop(shape, rnd.Next(0, 300));

                canvas.Children.Add(shape);
            }
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

            var mousePos = e.GetPosition(canvas);

            double left = mousePos.X - (element.ActualWidth / 2);
            double top = mousePos.Y - (element.ActualHeight / 2);
            Canvas.SetLeft(element, left);
            Canvas.SetTop(element, top);
        }
    }
}
