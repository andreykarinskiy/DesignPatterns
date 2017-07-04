using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public sealed class Schedule
    {
        private readonly ICollection<Appointment> allAppointments = new HashSet<Appointment>();

        public Appointment CreateAppointment(Patient patient, Doctor doctor, DateTime from, DateTime to)
        {
            if (IsInvalidInterval(from, to))
            {
                throw new ArgumentException("Это интервал времени уже занят");
            }

            var appointment = new Appointment(this, from, to, doctor, patient);

            allAppointments.Add(appointment);

            return appointment;
        }

        private bool IsInvalidInterval(DateTime from, DateTime to)
        {
            return allAppointments.SingleOrDefault(o => Intersect(o, from, to)) != null;
        }

        private bool Intersect(Appointment appointment, DateTime from, DateTime to)
        {
            throw new NotImplementedException();

        }
    }
}
