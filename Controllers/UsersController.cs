using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using EnjoyDialogs.SCIM.Infrastructure;
using EnjoyDialogs.SCIM.Models;
using EnjoyDialogs.SCIM.Services;
using StructureMap;

namespace EnjoyDialogs.SCIM.Controllers
{
    [Authorize]
    [ScimExpceptionHandlerFilter]
    public class UsersController : ApiController
    {
        private readonly IUserService _userService;

        public UsersController ()
            : this(ObjectFactory.GetInstance<IUserService>())
        {
        }

        public UsersController (IUserService userService)
        {
            if (userService == null) throw new ArgumentException();
            _userService = userService;
        }

        // GET v1/Users/
        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            var result = _userService.GetAll();

            return result;
        }

        // GET v1/Users/5
        [HttpGet]
        [ApiDoc("Gets a user by ID.")]
        [ApiParameterDoc("id", "The ID of the user.", typeof(UserModel))]
        public HttpResponseMessage Get(Guid id)
        {
            var user = _userService.Get(id);

            if (user == null)
            {
                throw new ScimException(HttpStatusCode.NotFound , string.Format("Resource {0} not found", id));
            }


            IContentNegotiator negotiator = this.Configuration.Services.GetContentNegotiator();
            ContentNegotiationResult result = negotiator.Negotiate(typeof (UserModel), this.Request, this.Configuration.Formatters);
            if (result == null)
            {
                throw new ScimException(HttpStatusCode.NotAcceptable, "Server does not support requested operation");
            }


            return new HttpResponseMessage()
                {
                    Content = new ObjectContent<UserModel>(
                        user, // What we are serializing  
                        result.Formatter, // The media formatter 
                        result.MediaType.MediaType // The MIME type 
                        )
                };
        }

        // POST v1/Users
        [HttpPost]
        public HttpResponseMessage Post([FromBody]string value)
        {
            throw new NotImplementedException();

            var item = new UserModel();

            var response = Request.CreateResponse<UserModel>(HttpStatusCode.Created, item); 

            string uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response; 
        }

        // PUT v1/Users/5
        [HttpPut]
        public void Put(Guid id, UserModel user) //[FromBody]string value)
        {
            throw new NotImplementedException();
            user.Id = id;
            //if (!repository.Update(user))
            //{
                throw new HttpResponseException(HttpStatusCode.NotFound);
            //} 

        }

        // DELETE v1/Users/5
        [HttpDelete]
        public HttpResponseMessage Delete(Guid id)
        {
            var user = _userService.Delete(id);
            if (user == null)
            {
                throw new ScimException(HttpStatusCode.NotFound, string.Format("Resource {0} not found", id));
            }

            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}
