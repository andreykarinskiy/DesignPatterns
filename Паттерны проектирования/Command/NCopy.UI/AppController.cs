using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Mef.CommonServiceLocator;
using Microsoft.Practices.ServiceLocation;

namespace NCopy.UI
{
    [Export]
    public sealed class AppController
    {
        public static void Main(string[] args)
        {
            using (var container = CreateContainer())
            {
                var appController = container.GetExportedValue<AppController>();

                appController.Run();
            }

            Console.ReadLine();
        }

        public void Run()
        {
            
        }

        private static CompositionContainer CreateContainer()
        {
            var aggregateCatalog = new AggregateCatalog();

            var appCatalog = new ApplicationCatalog();
            aggregateCatalog.Catalogs.Add(appCatalog);

            var container = new CompositionContainer(aggregateCatalog);

            ServiceLocator.SetLocatorProvider(() => new MefServiceLocator(container));
            
            return container;
        }
    }
}
