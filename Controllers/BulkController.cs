using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EnjoyDialogs.SCIM.Infrastructure;

namespace EnjoyDialogs.SCIM.Controllers
{
    [ScimExpceptionHandlerFilter]
    public class BulkController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            throw new NotImplementedException();
            return "urn:scim:schemas:core:1.0";
        }
    }
}
