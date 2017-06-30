using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [Export]
    public class Program
    {
        [ImportMany]
        public ExportFactory<Command, ICommandInfo>[] commands;

        static void Main(string[] args)
        {
            var catalog = new ApplicationCatalog();
            var container = new CompositionContainer(catalog);

            var app = container.GetExportedValue<Program>();
            app.Run();
        }

        public void Run()
        {
            var c1 = commands[0].CreateExport();
            var c2 = commands[0].CreateExport();

            var eq = c1 == c2;
        }
    }

    public abstract class Command { }

    [Export(typeof(Command))]
    [ExportMetadata("Name", "CUT")]
    public class CutCommand : Command { }

    public interface ICommandInfo
    {
        string Name { get; }
    }
}
