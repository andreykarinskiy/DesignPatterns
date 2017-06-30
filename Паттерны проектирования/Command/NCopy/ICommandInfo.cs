using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCopy
{
    public interface ICommandInfo
    {
        string Name { get; }

        string Description { get; }
    }
}
