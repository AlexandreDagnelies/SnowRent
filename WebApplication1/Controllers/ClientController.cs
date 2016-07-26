
using SnowRentLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApplication1.Controllers.Base;

namespace WebApplication1.Controllers
{
    public class ClientController : BaseController<Client>
    {
        [Route("api/Clients")]
        public override Task<IHttpActionResult> Post(IEnumerable<Client> values)
        {
            return base.Post(values);
        }

        [Route("api/Clients")]
        public override Task<IHttpActionResult> Put(IEnumerable<Client> values)
        {
            return base.Put(values);
        }

        [Route("api/Clients")]
        public override Task<IHttpActionResult> Delete(IEnumerable<Client> values)
        {
            return base.Delete(values);
        }
    }
}
