using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace ResourceServer.Controllers
{
    [EnableCors(origins: "http://localhost:8003", headers: "accept, authorization", methods: "*")]
    [Authorize]
    public class MeController : ApiController
    {
        
        [HttpGet]
        public string Get()
        {
            return this.User.Identity.Name;
        }
    }
}
