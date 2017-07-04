using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Logger
    {
        private static Lazy<Logger> instance { get; } = new Lazy<Logger>(() => new Logger());

        public static Logger Instance => instance.Value;

        public void Write(string message)
        {
            // Логика логгирования
        }
    }
}
