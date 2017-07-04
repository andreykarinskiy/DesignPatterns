using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class EmployeeDataAccessProxy : Employee
    {
        private readonly PersonalityContext db;
        private readonly IEquatable<object> primaryKey;

        private Employee state;

        public EmployeeDataAccessProxy(PersonalityContext db, IEquatable<object> primaryKey)
        {
            this.db = db;
            this.primaryKey = primaryKey;
        }

        public override string FirstName
        {
            get
            {
                LoadIfNeeded();
                return state.FirstName;
            }

            set
            {
                LoadIfNeeded();
                state.FirstName = value;
            }
        }
        
        private void LoadIfNeeded()
        {
            if (NotLoaded())
            {
                Load();
            }
        }

        private void Load()
        {
            state = db.Employees.Find(primaryKey);

            MarkAsLoaded();
        }

        private bool NotLoaded()
        {
            throw new NotImplementedException();
        }

        private void MarkAsLoaded()
        {
            throw new NotImplementedException();
        }
    }
}
