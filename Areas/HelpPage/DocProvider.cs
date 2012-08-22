using System;
using System.Linq;
using System.Web.Http.Controllers;
using System.Web.Http.Description;
using EnjoyDialogs.SCIM.Infrastructure;

namespace EnjoyDialogs.SCIM.Areas.HelpPage
{
    public class DocProvider : IDocumentationProvider
    {
        public string GetDocumentation(HttpParameterDescriptor parameterDescriptor)
        {
            string doc = "";
            var attr = parameterDescriptor.ActionDescriptor
                .GetCustomAttributes<ApiParameterDocAttribute>()
                .FirstOrDefault(p => p.Parameter == parameterDescriptor.ParameterName);
            if (attr != null)
            {
                doc = attr.Documentation;
            }
            return doc;
        }

        public string GetDocumentation(HttpActionDescriptor actionDescriptor)
        {
            string doc = "";
            var attr = actionDescriptor.GetCustomAttributes<ApiDocAttribute>().FirstOrDefault();
            if (attr != null)
            {
                doc = attr.Documentation;
            }
            return doc;
        }

        public Type GetResultType(HttpParameterDescriptor parameterDescriptor)
        {
            Type type = null;
            var attr = parameterDescriptor.ActionDescriptor
                .GetCustomAttributes<ApiParameterDocAttribute>()
                .FirstOrDefault(p => p.Parameter == parameterDescriptor.ParameterName);
            if (attr != null)
            {
                type = attr.ResultType;
            }
            return type;
        }
    }
}