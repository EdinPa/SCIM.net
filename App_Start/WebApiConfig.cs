using System;
using System.Web.Http;
using EnjoyDialogs.SCIM.Infrastructure;

namespace EnjoyDialogs.SCIM
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.MessageHandlers.Add(new MethodOverrideHandler());
            //config.MessageHandlers.Add(new CustomHeaderHandler());
            //config.MessageHandlers.Add(new ApiKeyHandler("secret"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi_v1",
                routeTemplate: "v1/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
