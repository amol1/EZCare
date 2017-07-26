using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using EZConnect.Models;

namespace EZConnect.Controllers
{
    public class ParentController : ApiController
    {
        // GET: api/child
        [HttpGet]
        public async Task<IHttpActionResult> Get( string id )
        {
            var userId = User.Identity.Name;

            Parent parent = new Parent();

            Child child = new Child()
            {
                Id = "Child1",
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

            parent.Children.Add( child );

            Child child2 = new Child
            {
                Id = "Child2",
                Age = 2,
                Name = "Joe",
                Condition = "Autism"
            };

            parent.Children.Add( child2 );

            return Ok( parent );
        }
    }
}
