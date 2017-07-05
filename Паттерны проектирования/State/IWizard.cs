using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface IWizard
    {
        string Text { get; }

        void GoNext();

        void GoPrev();

        void Cancel();

        void Finish();
    }
}
