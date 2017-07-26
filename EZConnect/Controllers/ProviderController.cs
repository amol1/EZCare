using System;
using System.Collections;
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
    public class ProviderController : ApiController
    {
        // GET: api/provider
        [HttpGet]
        public async Task<IHttpActionResult> Get(  )
        {
            var userId = User.Identity.Name;

            ICollection<Provider> providers = new Collection<Provider>();

            Provider provider = new Provider();
            provider.Name = "Dr. John Doe";
            provider.Address = "123 NE 4th St., Redmond, WA 98052";
            provider.Specialty = "Rheumatologist";
            provider.Rating = 4.2;

            providers.Add( provider );

            return Ok( providers );
        }
    }
}
