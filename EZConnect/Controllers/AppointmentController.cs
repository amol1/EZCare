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
    public class AppointmentController : ApiController
    {
        // GET: api/child
        [HttpGet]
        public async Task<IHttpActionResult> Get( string id )
        {
            var userId = User.Identity.Name;

            Appointment appointment = new Appointment()
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
            };

            return Ok( appointment );
        }
    }
}
