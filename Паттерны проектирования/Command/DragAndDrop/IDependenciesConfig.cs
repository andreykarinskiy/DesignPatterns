using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;

namespace DragAndDrop
{
    public interface IDependenciesConfig
    {
        void Configure(IUnityContainer container);
    }
}
