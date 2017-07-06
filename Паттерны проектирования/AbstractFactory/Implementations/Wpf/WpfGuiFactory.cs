using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory.Model;

namespace AbstractFactory.Implementations.Wpf
{
    public sealed class WpfGuiFactory : IGuiFactory
    {
        public IWindow CreateWindow()
        {
            return new WpfWindow();
        }

        public IButton CreateButton()
        {
            throw new NotImplementedException();
        }
    }
}
