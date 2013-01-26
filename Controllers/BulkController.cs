using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EnjoyDialogs.SCIM.Data.Contracts;
using EnjoyDialogs.SCIM.Infrastructure;

namespace EnjoyDialogs.SCIM.Controllers
{
    [Authorize]
    [ScimExpceptionHandlerFilter]
    public class BulkController : ApiControllerBase
    {
        public BulkController(IUnitOfWork uow)
        {
            Uow = uow;
        }

        [HttpGet]
        public string Get()
        {
            throw new NotImplementedException();
            return "urn:scim:schemas:core:1.0";
        }
    }
}
