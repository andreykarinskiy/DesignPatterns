using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Mvvm;

namespace DragAndDrop.ViewModels
{
    public class ShellViewModel : ViewModel
    {
        public ShellViewModel()
        {
            Title = "Drag and Drop demo";
        }

        public string Title
        {
            get => Get();
            set => Set(value);
        }
    }
}
