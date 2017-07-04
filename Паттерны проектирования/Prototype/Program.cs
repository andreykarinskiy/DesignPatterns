using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var person1 = new Employee
            {
                FirstName = "Василий",
                LastName = "Пупкин",
                Organization = "Рога и Копыта",
                WorkPhone = "322223223322",
                WorkAddress = "Красная Площадь"
            };

            var person2 = (Employee)person1.Clone();
            person2.FirstName = "Абрам";
            person2.LastName = "Шниперсон";
        }
    }
}
