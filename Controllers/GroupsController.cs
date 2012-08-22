using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EnjoyDialogs.SCIM.Infrastructure;
using EnjoyDialogs.SCIM.Models;
using EnjoyDialogs.SCIM.Services;
using StructureMap;

namespace EnjoyDialogs.SCIM.Controllers
{
    [NotImplExceptionFilter]
    public class GroupsController : ApiController
    {
                private readonly IUserService _userService;

        public GroupsController ()
            : this(ObjectFactory.GetInstance<IUserService>())
        {
        }

        public GroupsController (IUserService userService)
        {
            if (userService == null) throw new ArgumentException();
            _userService = userService;
        }

        // GET v1/Groups/
        [HttpGet]
        public IEnumerable<GroupModel> Get()
        {
            throw new NotImplementedException();
            var result = new List<GroupModel>();

            return result;
        }

        // GET v1/Groups/5
        [HttpGet]
        public GroupModel Get(Guid id)
        {
            throw new NotImplementedException();
            var result = new GroupModel();

            return result;
        }

        // POST v1/Groups
        [HttpPost]
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // PUT v1/Groups/5
        [HttpPut]
        public void Put(Guid id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE v1/Groups/5
        [HttpDelete]
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
