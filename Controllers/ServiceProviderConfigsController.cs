using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using EnjoyDialogs.SCIM.Models;


namespace EnjoyDialogs.SCIM.Controllers
{
    public class ServiceProviderConfigsController : ApiController
    {
        [System.Web.Http.HttpGet]
        public ServiceProviderConfigsModel Get()
        {
            //var result = new ServiceProviderConfigs
            //    {
            //        schemas = new string[] { "urn:scim:schemas:core:1.0" },
            //        id = new Guid("2819c223-7f76-453a-919d-413861904646"),
            //        externalid = "bjensen",
            //        meta = new Meta
            //            {
            //                created = DateTime.Now,
            //                lastModified = DateTime.Now,
            //                location = "http://scim.azurewebsites.net/v1/Users/2819c223-7f76-453a-919d-413861904646",
            //                version = "f250dd84f0671c3"
            //            },
            //        name = new Name
            //            {
            //                formatted = "Ms. Barbara J Jensen III",
            //                familyName = "Jensen",
            //                givenName = "Barbara"
            //            },
            //        userName = "bjensen",
            //        phoneNumbers = new[]
            //            {
            //                new PhoneNumbers
            //                    {
            //                        value = "555-555-8377",
            //                        type = "work"
            //                    }
            //            },
            //        emails = new[]
            //                {
            //                    new Emails
            //                        {
            //                            value = "bjensen@example.com",
            //                            type = "work"
            //                        }
            //                }
            //    };

            var thisUrl = this.Request.RequestUri.Scheme + "://" + this.Request.RequestUri.Host;

            var result = new ServiceProviderConfigsModel
                {
                    documentationUrl = thisUrl + "/help/scim",
                    patch = new PatchModel (),
                    bulk = new BulkModel
                        {
                            maxOperations = 1000,
                            maxPayloadSize = 200
                        },
                    filter = new FilterModel
                        {
                            maxResults = 200
                        },
                    changePassword = new ChangePasswordModel (),
                    sort = new SortModel (),
                    etag = new EtagModel (),
                    xmlDataFormat = new XmlDataFormatModel (),
                    authenticationSchemes = new[]
                        {
                            new AuthenticationScheme
                                {
                                    name = "OAuth Bearer Token",
                                    description = "Authentication Scheme using the OAuth Bearer Token Standard",
                                    specUrl = "http://tools.ietf.org/html/draft-ietf-oauth-v2-bearer-01",
                                    documentationUrl = thisUrl + "/help/oauth",
                                    type = "oauthbearertoken",
                                    primary = true
                                },
                            new AuthenticationScheme
                                {
                                    name = "HTTP Basic",
                                    description = "Authentication Scheme using the Http Basic Standard",
                                    specUrl = "http://www.ietf.org/rfc/rfc2617.txt",
                                    documentationUrl = thisUrl + "/help/httpBasic",
                                    type = "httpbasic"

                                }
                        }

                };
             
            return result;
        }
    }
}
