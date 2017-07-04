using System;
using Command.Services;

namespace Command
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var filesystemManager = new FilesystemManager(new FilesystemStub());

            filesystemManager.CopyDirectory("c://old", "d://new");

            Console.ReadLine();
        }
    }
}
