using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnjoyDialogs.SCIM.Security
{
    public class BasicAuthMessageHandler : DelegatingHandler
    {
        private const string BASIC_AUTH_RESPONSE_HEADER = "WWW-Authenticate";
        private const string BASIC_AUTH_RESPONSE_HEADER_VALUE = "Basic";

        public IProvidePrincipal PrincipalProvider { get; set; }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            AuthenticationHeaderValue authValue = request.Headers.Authorization;
            if (authValue != null && !String.IsNullOrWhiteSpace(authValue.Parameter))
            {
                var parsedCredentials = ParseAuthorizationHeader(authValue.Parameter);
                if (parsedCredentials != null)
                {
                    Thread.CurrentPrincipal = PrincipalProvider.CreatePrincipal(parsedCredentials.Username, parsedCredentials.Password);
                }
            }
            return base.SendAsync(request, cancellationToken)
                .ContinueWith(task =>
                    {
                        var response = task.Result;
                        if (response.StatusCode == HttpStatusCode.Unauthorized && !response.Headers.Contains(BASIC_AUTH_RESPONSE_HEADER))
                        {
                            response.Headers.Add(BASIC_AUTH_RESPONSE_HEADER
                                                 , BASIC_AUTH_RESPONSE_HEADER_VALUE);
                        }
                        return response;
                    });
        }

        //protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        //{
        //    AuthenticationHeaderValue authValue = request.Headers.Authorization;
        //    if (authValue == null || authValue.Scheme != "Basic")
        //    {
        //        return
        //            Task<HttpResponseMessage>.Factory.StartNew(
        //                () => new HttpResponseMessage(HttpStatusCode.Unauthorized));
        //    }
        //    var encoded = authValue.Parameter;
        //    var encoding = Encoding.GetEncoding("iso-8859-1");
        //    var userPass = encoding.GetString(Convert.FromBase64String(encoded));
        //    int sep = userPass.IndexOf(':');
        //    var username = userPass.Substring(0, sep);
        //    var identity = new GenericIdentity(username, "Basic");
        //    request.Properties.Add(HttpPropertyKeys.UserPrincipalKey, new GenericPrincipal(identity, new string[] { }));
        //    return base.SendAsync(request, cancellationToken);
        //}


        private BasicAuthCredentials ParseAuthorizationHeader(string authHeader)
        {
            string[] credentials = Encoding.ASCII.GetString(Convert.FromBase64String(authHeader)).Split(new[] {':'});
            if (credentials.Length != 2 || string.IsNullOrEmpty(credentials[0]) || string.IsNullOrEmpty(credentials[1])) return null;
            return new BasicAuthCredentials
                {
                    Username = credentials[0],
                    Password = credentials[1],
                };
        }
    }

    public class BasicAuthCredentials : ICredentials
    {
        public NetworkCredential GetCredential(Uri uri, string authType)
        {
            throw new NotImplementedException();
        }

        public string Username { get; set; }
        public string Password { get; set; }
    }


}