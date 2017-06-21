using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop.Wpf.Core
{
    public interface IMvvmTypeLocator
    {
        Type GetViewModelTypeFromViewType(Type viewType);

        Type GetViewTypeFromViewModelType(Type viewModelType);

        Type GetViewTypeFromViewName(string viewName);
    }
}
