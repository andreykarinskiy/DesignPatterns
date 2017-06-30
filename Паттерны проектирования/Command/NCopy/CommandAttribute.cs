using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCopy
{
    public sealed class CommandAttribute : ExportMetadataAttribute, ICommandInfo
    {
        public CommandAttribute(string name, string description) : base(typeof(Command))
        {
            Name = name;
            Description = description;
        }

        public string Name { get; }

        public string Description { get; }
    }
}
