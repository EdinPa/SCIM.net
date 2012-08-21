using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EnjoyDialogs.SCIM.Controllers
{
    public class BulkController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "urn:scim:schemas:core:1.0";
        }
    }
}
