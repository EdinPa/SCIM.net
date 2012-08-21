using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EnjoyDialogs.SCIM.Models;

namespace EnjoyDialogs.SCIM.Controllers
{
    public class GroupsController : ApiController
    {
        // GET v1/Groups/
        [HttpGet]
        public IEnumerable<GroupModel> Get()
        {
            var result = new List<GroupModel>();

            return result;
        }

        // GET v1/Groups/5
        [HttpGet]
        public GroupModel Get(Guid id)
        {
            var result = new GroupModel();

            return result;
        }

        // POST v1/Groups
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT v1/Groups/5
        [HttpPut]
        public void Put(Guid id, [FromBody]string value)
        {
        }

        // DELETE v1/Groups/5
        [HttpDelete]
        public void Delete(Guid id)
        {
        }
    }
}
