using System;
using System.Web.Http;
using EnjoyDialogs.SCIM.Infrastructure;
using EnjoyDialogs.SCIM.Models;

namespace EnjoyDialogs.SCIM.Controllers
{
    [AllowAnonymous]
    [ScimExpceptionHandlerFilter]
    public class SchemasController : ApiController
    {
        [HttpGet]
        public SchemaModel Users(string id = "Users")
        {
            SchemaModel result;
            if (id.ToLower() == "groups")
            {
                #region Group SchemaModel
                result = new SchemaModel
                    {
                        Id = Consts.DEFAULT_SCHEMA + ":Group",
                        Name = "Group",
                        Description = "Core Group",
                        Schema = Consts.DEFAULT_SCHEMA,
                        Endpoint = "/Groups",
                        Attributes = new[]
                            {
                                new SchemaAttributeModel
                                    {
                                        Name = "id",
                                        Type = "string",
                                        MultiValued = false,
                                        Description = "Unique identifier for the SCIM resource as defined by the Service Provider. Each representation of the resource MUST include a non-empty id value. This identifier MUST be unique across the Service Provider's entire set of resources. It MUST be a stable, non-reassignable identifier that does not change when the same resource is returned in subsequent requests. The value of the id attribute is always issued by the Service Provider and MUST never be specified by the Service Consumer. REQUIRED.",
                                        Schema = Consts.DEFAULT_SCHEMA,
                                        ReadOnly = true,
                                        Required = true,
                                        CaseExact = false
                                    },
                                new SchemaAttributeModel
                                    {
                                        Name = "displayName",
                                        Type = "string",
                                        MultiValued = false,
                                        Description = "Unique displayName. REQUIRED.",
                                        Schema = Consts.DEFAULT_SCHEMA,
                                        ReadOnly = true,
                                        Required = true,
                                        CaseExact = false
                                    },
                                new SchemaAttributeModel
                                    {
                                        Name = "members",
                                        Type = "complex",
                                        MultiValued = true,
                                        Description = "List of members",
                                        Schema = Consts.DEFAULT_SCHEMA,
                                        ReadOnly = false,
                                        Required = false,
                                        CaseExact = false,
                                        SubAttributes = new[]
                                            {
                                                new SchemaAttributeModel
                                                    {
                                                        Name = "value",
                                                        Type = "string",
                                                        MultiValued = false,
                                                        Description = "Unique identifier for this group member",
                                                        Schema = Consts.DEFAULT_SCHEMA,
                                                        ReadOnly = true,
                                                        Required = true,
                                                        CaseExact = false
                                                    },
                                                new SchemaAttributeModel
                                                    {
                                                        Name = "display",
                                                        Type = "string",
                                                        MultiValued = false,
                                                        Description = "",
                                                        Schema = Consts.DEFAULT_SCHEMA,
                                                        ReadOnly = true,
                                                        Required = true,
                                                        CaseExact = false
                                                    }
                                            }
                                    }
                            }
                    };
                #endregion
            }
            else
            {
                #region User SchemaModel
                result = new SchemaModel
                    {
                        Id = Consts.DEFAULT_SCHEMA + ":User",
                        Name = "User",
                        Description = "Core User",
                        Schema = Consts.DEFAULT_SCHEMA,
                        Endpoint = "/Users",
                        Attributes = new[]
                            {
                                new SchemaAttributeModel
                                    {
                                        Name = "id",
                                        Type = "string",
                                        MultiValued = false,
                                        Description = "Unique identifier for the SCIM resource as defined by the Service Provider. Each representation of the resource MUST include a non-empty id value. This identifier MUST be unique across the Service Provider's entire set of resources. It MUST be a stable, non-reassignable identifier that does not change when the same resource is returned in subsequent requests. The value of the id attribute is always issued by the Service Provider and MUST never be specified by the Service Consumer. REQUIRED.",
                                        Schema = Consts.DEFAULT_SCHEMA,
                                        ReadOnly = true,
                                        Required = true,
                                        CaseExact = false
                                    },
                                new SchemaAttributeModel
                                    {
                                        Name = "userName",
                                        Type = "string",
                                        MultiValued = false,
                                        Description = "Unique userName. REQUIRED.",
                                        Schema = Consts.DEFAULT_SCHEMA,
                                        ReadOnly = true,
                                        Required = true,
                                        CaseExact = false
                                    },
                                new SchemaAttributeModel
                                    {
                                        Name = "externalId",
                                        Type = "string",
                                        MultiValued = false,
                                        Description = "",
                                        Schema = Consts.DEFAULT_SCHEMA,
                                        ReadOnly = true,
                                        Required = false,
                                        CaseExact = false
                                    },
                                new SchemaAttributeModel
                                    {
                                        Name = "name",
                                        Type = "complex",
                                        MultiValued = false,
                                        Description = "",
                                        Schema = Consts.DEFAULT_SCHEMA,
                                        ReadOnly = true,
                                        Required = false,
                                        CaseExact = false
                                    },
                                new SchemaAttributeModel
                                    {
                                        Name = "nickName",
                                        Type = "string",
                                        MultiValued = false,
                                        Description = "",
                                        Schema = Consts.DEFAULT_SCHEMA,
                                        ReadOnly = true,
                                        Required = false,
                                        CaseExact = false
                                    },
                                new SchemaAttributeModel
                                    {
                                        Name = "profileUrl",
                                        Type = "string",
                                        MultiValued = false,
                                        Description = "",
                                        Schema = Consts.DEFAULT_SCHEMA,
                                        ReadOnly = true,
                                        Required = false,
                                        CaseExact = false
                                    }
                            }
                    };
                #endregion
            }

            return result;
        }
    }
}
