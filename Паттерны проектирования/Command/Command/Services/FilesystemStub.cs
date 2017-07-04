using System;
using System.Collections.Generic;
using System.IO;

namespace Command.Services
{
    public sealed class FilesystemStub : IFilesystem
    {
        public void CopyFile(string source, string destination)
        {
            Console.WriteLine($"Копирование из {source} в {destination}");

            if (Path.GetFileNameWithoutExtension(source) == "c")
            {
                throw new IOException();
            }
        }

        public IEnumerable<string> GetFiles(string source)
        {
            yield return "a.txt";
            yield return "b.txt";
            yield return "c.txt";
        }

        public void CreateDirectory(string destination)
        {
            Console.WriteLine($"Создание каталога {destination}");
        }

        public void DeleteFile(string destination)
        {
            Console.WriteLine($"Удаление файла {destination}");
        }

        public void DeleteEmptyDirectory(string destination)
        {
            Console.WriteLine($"Удаление пустого каталога {destination}");
        }
    }
}