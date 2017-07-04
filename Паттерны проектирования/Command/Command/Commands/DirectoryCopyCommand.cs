using System.Collections.Generic;
using System.Linq;
using Command.Services;

namespace Command.Commands
{
    public sealed class DirectoryCopyCommand : ICommand
    {
        private readonly IFilesystem filesystem;
        private readonly Stack<ICommand> children = new Stack<ICommand>(); 
        private readonly string source;
        private readonly string destination;

        public DirectoryCopyCommand(IFilesystem filesystem, string source, string destination)
        {
            this.filesystem = filesystem;

            this.source = source;
            this.destination = destination;
        }

        public void Execute()
        {
            var allFiles = filesystem.GetFiles(source);

            foreach (var file in allFiles)
            {
                var command = new FileCopyCommand(filesystem, $"{source}/{file}", $"{destination}/{file}");

                command.Execute();

                children.Push(command);
            }

            filesystem.CreateDirectory(destination);
        }

        public void Unexecute()
        {
            while (children.Any())
            {
                var command = children.Pop();

                command.Unexecute();
            }

            filesystem.DeleteEmptyDirectory(destination);
        }
    }
}