using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using DragAndDrop.ViewModels;

using Microsoft.Practices.Unity;

using Prism.Mvvm;
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

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver(t =>
            {
                var viewName = t.Name;

                // Найти в доступных сборках наследника ViewModel, подходящего по имени к View.

                var viewModelName = viewName.Replace("View", "ViewModel");

                var viewModel = Assembly
                    .GetExecutingAssembly()
                    .GetTypes()
                    .SingleOrDefault(o => o.Name == viewModelName);

                return viewModel;
            });
        }

        public void Dispose()
        {
            Container.Dispose();
        }
    }
}
