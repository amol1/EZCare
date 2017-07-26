using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZConnect.Models
{
    class Appointment
    {
        public Child Child { get; set; }

        public DateTime AppointmentTime { get; set; }

        public Provider Provider { get; set; }
    }
}
