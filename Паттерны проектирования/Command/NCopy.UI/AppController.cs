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

    [Command("CUT", "descr")]
    public class CutCommand : Command { }

    
    [Command("Copy", "descr")]
    public sealed class CopyCommand : Command
    {
    }


    public interface ICommandInfo
    {
        string Name { get; }

        string Description { get; }
    }

    [MetadataAttribute, AttributeUsage(AttributeTargets.Class)]
    public class CommandAttribute : ExportAttribute/*Attribute,*/, ICommandInfo
    {
        public CommandAttribute(string name, string description) : base(typeof(Command))
        {
            Name = name;
            Description = description;
        }

        public string Name { get; }

        public string Description { get; }
    }
}
