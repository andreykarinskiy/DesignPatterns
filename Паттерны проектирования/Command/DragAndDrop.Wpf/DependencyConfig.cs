using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;

namespace DragAndDrop.Wpf
{
    public sealed class DependencyConfig : IDependenciesConfig
    {
        public void Configure(IUnityContainer container)
        {
            container.RegisterType<IShellView, Views.ShellView>(new ContainerControlledLifetimeManager());
        }
    }
}
