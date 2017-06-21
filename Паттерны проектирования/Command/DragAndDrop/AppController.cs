using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using Microsoft.Practices.Unity;

using Prism.Unity;

namespace DragAndDrop
{
    public sealed class AppController : UnityBootstrapper, IDisposable
    {
        private readonly IDependenciesConfig config;

        public AppController(IDependenciesConfig config)
        {
            this.config = config;
        }

        protected override DependencyObject CreateShell()
        {
            // ReSharper disable once SuspiciousTypeConversion.Global
            return (DependencyObject) Container.Resolve<IShellView>();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            config.Configure(Container);
        }

        protected override void InitializeShell()
        {
            Container.Resolve<IShellView>().Show();
        }

        public void Dispose()
        {
            Container.Dispose();
        }
    }
}
