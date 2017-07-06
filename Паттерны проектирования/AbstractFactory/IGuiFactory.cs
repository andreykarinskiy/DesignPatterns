using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory.Model;

namespace AbstractFactory
{
    public interface IGuiFactory
    {
        IWindow CreateWindow();

        IButton CreateButton();
    }
}
