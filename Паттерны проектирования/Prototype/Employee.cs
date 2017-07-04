using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public sealed class Employee : ICloneable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Organization { set; get; }

        public string WorkPhone { get; set; }

        public string WorkAddress { get; set; }

        public object Clone()
        {
            return new Employee
            {
                FirstName = FirstName,
                LastName = LastName,
                Organization = Organization,
                WorkAddress = WorkAddress,
                WorkPhone = WorkPhone
            };
        }
    }
}
