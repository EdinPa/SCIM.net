using System;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using CacheCow.Server;
using EnjoyDialogs.SCIM.Areas.HelpPage;

namespace EnjoyDialogs.SCIM
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            IoCConfig.RegisterStructuremap(GlobalConfiguration.Configuration);

            MvcHandler.DisableMvcResponseHeader = true;

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());


            AreaRegistration.RegisterAllAreas();

            GlobalConfiguration.Configuration.MessageHandlers.Add(new CachingHandler());

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            FormatingConfig.Configure(GlobalConfiguration.Configuration);
            AuthProvidersConfig.RegisterAuthProvider(GlobalConfiguration.Configuration);

            GlobalConfiguration.Configuration.Services.Replace(typeof(IDocumentationProvider), new DocProvider());

        }

        public override string GetVaryByCustomString(HttpContext context, string custom)
        {
            if (custom.Equals("RequestVerificationTokenCookie", StringComparison.OrdinalIgnoreCase))
            {
                string verificationTokenCookieName =
                  context.Request.Cookies
                    .Cast<string>()
                    .FirstOrDefault(cn => cn.StartsWith("__requestverificationtoken", StringComparison.InvariantCultureIgnoreCase));
                if (!string.IsNullOrEmpty(verificationTokenCookieName))
                {
                    return context.Request.Cookies[verificationTokenCookieName].Value;
                }
            }
            return base.GetVaryByCustomString(context, custom);
        }
    }
}