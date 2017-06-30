using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShowAvailableCommands();


            Console.ReadLine();
        }

        private static void ShowAvailableCommands()
        {
            var commandTypes = typeof(Program).Assembly.GetTypes().Where(t => typeof(Command).IsAssignableFrom(t) && !t.IsAbstract);

            foreach (var cmdType in commandTypes)
            {
                var attr = cmdType.GetCustomAttribute<CommandAttribute>();

                var commandText = $"{attr.Name} {attr.Description}";

                Console.WriteLine(commandText);
            }
        }
    }

    public abstract class Command
    {
        public abstract void Execute();
    }

    [Command("copy", "Копирует файлы")]
    public sealed class CopyCommand : Command
    {
        private readonly string source;
        private readonly string destination;

        public CopyCommand([Argument("source")]string source, [Argument("destination")]string destination)
        {
            this.source = source;
            this.destination = destination;
        }

        public override void Execute()
        {
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public sealed class CommandAttribute : Attribute
    {
        public CommandAttribute(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public string Name { get; }

        public string Description { get; }
    }

    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class ArgumentAttribute : Attribute
    {
        public ArgumentAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
