using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EZConnect.Models
{
    class Child : Person
    {
        public string Condition { get; set; }

        public ICollection<Appointment> Appointments = new Collection<Appointment>();
    }
}
