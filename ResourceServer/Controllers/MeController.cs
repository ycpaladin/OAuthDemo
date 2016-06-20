using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiContrib.Filters;

namespace ResourceServer.Controllers
{
    [Authorize]
    public class MeController : ApiController
    {
        [EnableCors]
        public string Get()
        {
            return this.User.Identity.Name;
        }
    }
}
