using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TokenAuthenticationWEBAPI.Controllers
{
    public class TestController : ApiController
    {
        [Authorize]
        [HttpGet]
        [Route("api/test/resource")]
        public IHttpActionResult GetResource()
        {            
            return Ok("Hello: You are granted to access api");
        }
    }
}
