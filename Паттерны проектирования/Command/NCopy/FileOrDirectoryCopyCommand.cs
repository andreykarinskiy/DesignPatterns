using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCopy
{
    [Command("copy", "Копирование файла или каталога")]
    public sealed class FileOrDirectoryCopyCommand : Command
    {
        private readonly string from;
        private readonly string to;

        public FileOrDirectoryCopyCommand()
        {
        }

        //[ImportingConstructor]
        public FileOrDirectoryCopyCommand([Parameter("from")] string from, [Parameter("to")] string to)
        {
            this.from = from;
            this.to = to;
        }

        public override void Execute()
        {

        }
    }
}
