using System;
using System.Net;

namespace EnjoyDialogs.SCIM.Infrastructure
{
    public class ScimException : ApplicationException
    {

        public ScimException (HttpStatusCode statusCode, string message)
            : base(message)
        {
            this.StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; set; }
    }
}