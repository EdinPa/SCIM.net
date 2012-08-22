using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using EnjoyDialogs.SCIM.Models;
using EnjoyDialogs.SCIM.Services;
using StructureMap;


namespace EnjoyDialogs.SCIM.Controllers
{
    public class ServiceProviderConfigsController : ApiController
    {
        [System.Web.Http.HttpGet]
        public ServiceProviderConfigModel Get()
        {
            //var result = new ServiceProviderConfigs
            //    {
            //        schemas = new string[] { "urn:scim:schemas:core:1.0" },
            //        id = new Guid("2819c223-7f76-453a-919d-413861904646"),
            //        externalid = "bjensen",
            //        meta = new Meta
            //            {
            //                Created = DateTime.Now,
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


            var svc = ObjectFactory.GetInstance<IUserService>();

            var thisUrl = this.Request.RequestUri.Scheme + "://" + this.Request.RequestUri.Host;

            var result = new ServiceProviderConfigModel
                {
                    DocumentationUrl = thisUrl + "/help/scim",
                    Patch = new PatchModel (),
                    Bulk = new BulkModel
                        {
                            MaxOperations = 1000,
                            MaxPayloadSize = 200
                        },
                    Filter = new FilterModel
                        {
                            MaxResults = 200
                        },
                    ChangePassword = new ChangePasswordModel (),
                    Sort = new SortModel (),
                    Etag = new EtagModel (),
                    XmlDataFormat = new XmlDataFormatModel (),
                    AuthenticationSchemes = new[]
                        {
                            new AuthenticationScheme
                                {
                                    Name = "OAuth Bearer Token",
                                    Description = "Authentication Scheme using the OAuth Bearer Token Standard",
                                    SpecUrl = "http://tools.ietf.org/html/draft-ietf-oauth-v2-bearer-01",
                                    DocumentationUrl = thisUrl + "/help/oauth",
                                    Type = "oauthbearertoken",
                                    Primary = true
                                },
                            new AuthenticationScheme
                                {
                                    Name = "HTTP Basic",
                                    Description = "Authentication Scheme using the Http Basic Standard",
                                    SpecUrl = "http://www.ietf.org/rfc/rfc2617.txt",
                                    DocumentationUrl = thisUrl + "/help/httpBasic",
                                    Type = "httpbasic"

                                }
                        }

                };
             
            return result;
        }
    }
}
