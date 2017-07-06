using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory.Implementations.Wpf;
using AbstractFactory.Model;

namespace AbstractFactory
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            IGuiFactory guiFactory = new WpfGuiFactory();

            IWindow window = guiFactory.CreateWindow();
            IButton button = guiFactory.CreateButton();
        }
    }
}
