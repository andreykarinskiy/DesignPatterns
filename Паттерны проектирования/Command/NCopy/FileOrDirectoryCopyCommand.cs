using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCopy
{
    [Command("copy")]
    public sealed class FileOrDirectoryCopyCommand : Command
    {
        public FileOrDirectoryCopyCommand([Parameter("from")] string from, [Parameter("to")] string to)
        {
        }

        public override void Execute()
        {

        }
    }
}
