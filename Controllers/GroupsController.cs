using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using EnjoyDialogs.SCIM.Data.Contracts;
using EnjoyDialogs.SCIM.Infrastructure;
using EnjoyDialogs.SCIM.Models;

namespace EnjoyDialogs.SCIM.Controllers
{
    [Authorize]
    [ScimExpceptionHandlerFilter]
    public class GroupsController : ApiControllerBase
    {
        public GroupsController(IUnitOfWork uow)
        {
            Uow = uow;
        }

        //private readonly IGroupService _groupService;

        //public GroupsController()
        //    : this(ObjectFactory.GetInstance<IGroupService>())
        //{
        //}

        //public GroupsController(IGroupService groupService)
        //{
        //    if (groupService == null) throw new ArgumentException();
        //    _groupService = groupService;
        //}

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
        public HttpResponseMessage Get(Guid id)
        {
            var group = Uow.Groups.GetById(id);

            if (group == null)
            {
                throw new ScimException(HttpStatusCode.NotFound, string.Format("Resource {0} not found", id));
            }


            IContentNegotiator negotiator = this.Configuration.Services.GetContentNegotiator();
            ContentNegotiationResult result = negotiator.Negotiate(typeof (UserModel), this.Request, this.Configuration.Formatters);
            if (result == null)
            {
                throw new ScimException(HttpStatusCode.NotAcceptable, "Server does not support requested operation");
            }


            return new HttpResponseMessage()
                {
                    Content = new ObjectContent<GroupModel>(
                        group, // What we are serializing  
                        result.Formatter, // The media formatter 
                        result.MediaType.MediaType // The MIME type 
                        )
                };
        }

        // POST v1/Groups
        [HttpPost]
        public HttpResponseMessage Post([FromBody] string value)
        {
            throw new NotImplementedException();

            var item = new GroupModel();

            var response = Request.CreateResponse<GroupModel>(HttpStatusCode.Created, item);

            string uri = Url.Link("DefaultApi", new {id = item.Id});
            response.Headers.Location = new Uri(uri);
            return response;
        }

        // PUT v1/Groups/5
        [HttpPut]
        public HttpResponseMessage Put(Guid id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // DELETE v1/Groups/5
        [HttpDelete]
        public HttpResponseMessage Delete(Guid id)
        {
            var group = Uow.Groups.GetById(id);
            if (group == null)
            {
                throw new ScimException(HttpStatusCode.NotFound, string.Format("Resource {0} not found", id));
            }

            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}
