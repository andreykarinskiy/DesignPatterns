using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public static class DbSetExtension
    {
        public static T Find<T>(this ISet<T> entities, IEquatable<object> primaryKey)
        {
            throw new NotImplementedException();
        }
    }
}
