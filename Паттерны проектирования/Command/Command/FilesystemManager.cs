using System.IO;
using Command.Commands;
using Command.Services;

namespace Command
{
    public sealed class FilesystemManager
    {
        private readonly IFilesystem filesystem;

        public FilesystemManager(IFilesystem filesystem)
        {
            this.filesystem = filesystem;
        }

        public void CopyFile(string source, string destination)
        {
            var command = new FileCopyCommand(filesystem, source, destination);
            ExecuteOrRecover(command);
        }

        public void CopyDirectory(string source, string destination)
        {
            var command = new DirectoryCopyCommand(filesystem, source, destination);
            ExecuteOrRecover(command);
        }

        private static void ExecuteOrRecover(ICommand command)
        {
            try
            {
                command.Execute();
            }
            catch (IOException)
            {
                command.Unexecute();

                throw new IOException("Ошибка и восстановление");
            }
        }
    }
}
