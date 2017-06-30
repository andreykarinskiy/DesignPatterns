using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Security.Policy;
using System.Threading;
using System.Threading.Tasks;

namespace NCopy.UI
{
    [Export]
    public sealed class AppController
    {
        private IEnumerable<ExportFactory<Command, ICommandInfo>> commandFactories;

        [ImportingConstructor]
        public AppController([ImportMany] IEnumerable<ExportFactory<Command, ICommandInfo>> commandFactories)
        {
            this.commandFactories = commandFactories;
        }

        public static void Main(string[] args)
        {
            var catalog = new ApplicationCatalog();
            var container = new CompositionContainer(catalog);

            var app = container.GetExportedValue<AppController>();
            app.Run();

            Console.ReadLine();
        }

        private void Run()
        {
            
        }
    }

    public abstract class Command
    {
    }

    [Export(typeof(Command))]
    [ExportMetadata("Name", "CUT")]
    [ExportMetadata("Description", "description")]
    public class CutCommand : Command { }

    public interface ICommandInfo
    {
        string Name { get; }

        string Description { get; }
    }

    [Export(typeof(Command))]
    [ExportMetadata("Name", "Copy")]
    [ExportMetadata("Description", "description")]
    public sealed class CopyCommand : Command
    {
        public CopyCommand([])
        {
        }
    }
}
