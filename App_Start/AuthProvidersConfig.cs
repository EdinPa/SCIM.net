using System.Web.Http;
using EnjoyDialogs.SCIM.Security;

namespace EnjoyDialogs.SCIM
{
    public class AuthProvidersConfig
    {
        public static void RegisterAuthProvider(HttpConfiguration config)
        {
            config.MessageHandlers.Add(new BasicAuthMessageHandler
                {
                    // TODO: Replace this with a real AuthProvider
                    PrincipalProvider = new DummyPrincipalProvider()
                });
        }
    }
}