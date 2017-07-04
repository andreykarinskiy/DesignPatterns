using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Employee
    {
        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
