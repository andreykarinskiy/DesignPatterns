using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DragAndDrop.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly AppController appController;

        public App()
        {
            appController = new AppController();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            appController.Run();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            appController.Dispose();

            base.OnExit(e);
        }
    }
}
