using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var schedule = new Schedule();
            var doctor = new Doctor();
            var patient = new Patient();
            var from = new DateTime();
            var to = new DateTime();


            var appointment = schedule.CreateAppointment(patient, doctor, from, to);
        }
    }
}
