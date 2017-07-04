using Command.Services;

namespace Command.Commands
{
    public sealed class FileCopyCommand : ICommand
    {
        private readonly IFilesystem filesystem;

        private readonly string source;
        private readonly string destination;

        public FileCopyCommand(IFilesystem filesystem, string source, string destination)
        {
            this.filesystem = filesystem;
            this.source = source;
            this.destination = destination;
        }

        public void Execute()
        {
            filesystem.CopyFile(source, destination);
        }

        public void Unexecute()
        {
            filesystem.DeleteFile(destination);
        }
    }
}