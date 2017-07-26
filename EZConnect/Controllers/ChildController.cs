using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using EZConnect.Models;

namespace EZConnect.Controllers
{
    //[Authorize]
    public class ChildController : ApiController
    {
        // GET: api/child
        [HttpGet]
        public async Task<IHttpActionResult> Get( string id )
        {
            var userId = User.Identity.Name;

            Child child = new Child()
            {
                Age = 5,
                Name = "Sally Smith",
                Condition = "Arthritis"
            };

            child.Appointments.Add(
                new Appointment()
                {
                    Provider = new Provider()
                    {
                        Name = "Jane Doe",
                        Address = "1 MS Way, Redmond WA 98052",
                        Rating = 4.2,
                        Specialty = "Physical Therapy",
                        InsuranceAccepted = "Premera, Kaiser, Cigna"
                    },
                    AppointmentTime = DateTime.Now.AddDays( 2 )
                }
            );

            child.Appointments.Add(
                new Appointment()
                {
                    Provider = new Provider()
                    {
                        Name = "Dr. john Doe",
                        Address = "2 MS Way, Redmond WA 98052",
                        Rating = 4.5,
                        Specialty = "Rheumatologist",
                        InsuranceAccepted = "Premera, Kaiser, Cigna"
                    },
                    AppointmentTime = DateTime.Now.AddDays( 15 )
                }
            );

            return Ok( child );
        }
    }
}
