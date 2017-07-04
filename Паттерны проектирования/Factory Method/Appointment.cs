using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Appointment
    {
        private readonly Schedule schedule;

        internal Appointment(Schedule schedule, DateTime from, DateTime to, Doctor doctor, Patient patient)
        {
            this.schedule = schedule;

            From = from;
            To = to;
            Doctor = doctor;
            Patient = patient;
        }

        public DateTime From { get; }

        public DateTime To { get; }

        public Doctor Doctor { get; }

        public Patient Patient { get; }
    }
}
