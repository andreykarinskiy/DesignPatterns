using System.Collections.Generic;

namespace Command.Services
{
    public interface IFilesystem
    {
        void CopyFile(string source, string destination);

        IEnumerable<string> GetFiles(string source);

        void CreateDirectory(string destination);

        void DeleteFile(string destination);

        void DeleteEmptyDirectory(string destination);
    }
}