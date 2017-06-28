using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public interface IShellView
    {
        void SetCanUndo(bool state);

        void SetCanRedo(bool state);
    }
}
