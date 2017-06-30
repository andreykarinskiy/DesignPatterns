using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Threading;
using System.Threading.Tasks;
using IN = System.Func<object, object, string>;

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
            var commandFactory = commandFactories.Single(o => o.Metadata.Name == "Copy");
            var command = commandFactory.CreateExport().Value;
        }

        [Export("ArgumentProvider")]
        public string GetArgument(object ctorArgument, object source)
        {
            var ctor = source.GetType().GetConstructors().Single();

            foreach (var parameter in ctor.GetParameters())
            {
                //var argumentAttribute = parameter
                //    .GetCustomAttributes()
                //    .OfType<ArgumentAttribute>()
                //    .Single();

                Type a = parameter.ParameterType;
                var aa = parameter.GetCustomAttributes();

                Type b = ctorArgument.GetType();
                var bb = b.GetCustomAttributes();
            }

            return "PARAM";
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
        private readonly string from;
        private readonly string to;

        [ImportingConstructor]
        public CopyCommand([Argument("from")] IN from, [Argument("to")] IN to)
        {
            this.from = from(from, this);
            this.to = to(to, this);
        }
    }


    public interface ICommandInfo
    {
        string Name { get; }

        string Description { get; }
    }

    [MetadataAttribute, AttributeUsage(AttributeTargets.Class)]
    public class CommandAttribute : ExportAttribute, ICommandInfo
    {
        public CommandAttribute(string name, string description) : base(typeof(Command))
        {
            Name = name;
            Description = description;
        }

        public string Name { get; }

        public string Description { get; }
    }

    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class ArgumentAttribute : ImportAttribute
    {
        public ArgumentAttribute(string name) : base("ArgumentProvider")
        {
            Name = name;
        }

        public string Name { get; }
    }

    public interface ICommandArgumentProvider
    {
        //string 
    }
}
