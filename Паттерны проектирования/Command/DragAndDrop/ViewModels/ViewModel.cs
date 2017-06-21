using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Prism.Mvvm;

namespace DragAndDrop.ViewModels
{
    public abstract class ViewModel : BindableBase
    {
        private readonly IDictionary<string, object> dynamicProperties = new Dictionary<string, object>();

        protected dynamic Get([CallerMemberName] string propertyName = null)
        {
            return dynamicProperties[propertyName];
        }

        protected void Set(object value, [CallerMemberName] string propertyName = null)
        {
            dynamicProperties[propertyName] = value;
            
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
    }
}
