using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using EnjoyDialogs.SCIM.Models;

namespace EnjoyDialogs.SCIM.Infrastructure
{
    public class ScimExpceptionHandlerFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            var errors = new ErrorModel();
            var ex = context.Exception;
            do
            {
                if (ex is NotImplementedException)
                {
                    errors.Errors.Add(new ErrorDetailModel
                        {
                            Code = HttpStatusCode.NotImplemented,
                            Description = "Service Provider does not support the request operation"
                        });
                }
                else if (ex is ScimException)
                {
                    errors.Errors.Add(new ErrorDetailModel
                        {
                            Code = ((ScimException) ex).StatusCode,
                            Description = ex.Message
                        });
                }
                ex = ex.InnerException;
            } while (ex != null);


            IContentNegotiator negotiator = GlobalConfiguration.Configuration.Services.GetContentNegotiator();
            ContentNegotiationResult result = negotiator.Negotiate(typeof(ErrorModel), context.Request, GlobalConfiguration.Configuration.Formatters);

            context.Response = new HttpResponseMessage(errors.Errors[0].Code)
                {
                    Content = new ObjectContent<ErrorModel>(errors, result.Formatter, result.MediaType.MediaType)
                };
        }
    }
}