using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EnjoyDialogs.SCIM.Models;

namespace EnjoyDialogs.SCIM.Controllers
{
    public class UsersController : ApiController
    {
        // GET v1/Users/
        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            var result = new List<UserModel>();

            return result;
        }

        // GET v1/Users/5
        [HttpGet]
        public UserModel Get(Guid id)
        {
            var result = new UserModel();
            return result;
        }

        // POST v1/Users
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT v1/Users/5
        [HttpPut]
        public void Put(Guid id, [FromBody]string value)
        {
        }

        // DELETE v1/Users/5
        [HttpDelete]
        public void Delete(Guid id)
        {
        }
    }
}
