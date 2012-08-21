using System;
using System.Web.Http;
using EnjoyDialogs.SCIM.Models;

namespace EnjoyDialogs.SCIM.Controllers
{
    public class SchemasController : ApiController
    {
        [HttpGet]
        public SchemaModel Users(string id)
        {
            SchemaModel result;
            if (id.ToLower() == "groups")
            {
                result = new SchemaModel
                    {
                        id = Consts.DEFAULT_SCHEMA + ":Group",
                        name = "Group",
                        description = "Core Group",
                        schema = Consts.DEFAULT_SCHEMA,
                        endpoint = "/Groups",
                        attributes = new[]
                            {
                                new SchemaAttributeModel
                                    {
                                        name = "id",
                                        type = "string",
                                        multiValued = false,
                                        description =
                                            "Unique identifier for the SCIM resource as defined by the Service Provider. Each representation of the resource MUST include a non-empty id value. This identifier MUST be unique across the Service Provider's entire set of resources. It MUST be a stable, non-reassignable identifier that does not change when the same resource is returned in subsequent requests. The value of the id attribute is always issued by the Service Provider and MUST never be specified by the Service Consumer. REQUIRED.",
                                        schema = Consts.DEFAULT_SCHEMA,
                                        readOnly = true,
                                        required = true,
                                        caseExact = false
                                    },
                                new SchemaAttributeModel
                                    {
                                        name = "displayName",
                                        type = "string",
                                        multiValued = false,
                                        description = "Unique displayName. REQUIRED.",
                                        schema = Consts.DEFAULT_SCHEMA,
                                        readOnly = true,
                                        required = true,
                                        caseExact = false
                                    },
                                new SchemaAttributeModel
                                    {
                                        name = "members",
                                        type = "complex",
                                        multiValued = true,
                                        description = "List of members",
                                        schema = Consts.DEFAULT_SCHEMA,
                                        readOnly = false,
                                        required = false,
                                        caseExact = false,
                                        subAttributes = new[]
                                            {
                                                new SchemaAttributeModel
                                                    {
                                                        name = "value",
                                                        type = "string",
                                                        multiValued = false,
                                                        description = "Unique identifier for this group member",
                                                        schema = Consts.DEFAULT_SCHEMA,
                                                        readOnly = true,
                                                        required = true,
                                                        caseExact = false
                                                    },
                                                new SchemaAttributeModel
                                                    {
                                                        name = "display",
                                                        type = "string",
                                                        multiValued = false,
                                                        description = "",
                                                        schema = Consts.DEFAULT_SCHEMA,
                                                        readOnly = true,
                                                        required = true,
                                                        caseExact = false
                                                    }
                                            }
                                    }
                            }
                    };
            }
            else
            {
                result = new SchemaModel
                    {
                        id = Consts.DEFAULT_SCHEMA + ":User",
                        name = "User",
                        description = "Core User",
                        schema = Consts.DEFAULT_SCHEMA,
                        endpoint = "/Users",
                        attributes = new[]
                            {
                                new SchemaAttributeModel
                                    {
                                        name = "id",
                                        type = "string",
                                        multiValued = false,
                                        description =
                                            "Unique identifier for the SCIM resource as defined by the Service Provider. Each representation of the resource MUST include a non-empty id value. This identifier MUST be unique across the Service Provider's entire set of resources. It MUST be a stable, non-reassignable identifier that does not change when the same resource is returned in subsequent requests. The value of the id attribute is always issued by the Service Provider and MUST never be specified by the Service Consumer. REQUIRED.",
                                        schema = Consts.DEFAULT_SCHEMA,
                                        readOnly = true,
                                        required = true,
                                        caseExact = false
                                    },
                                new SchemaAttributeModel
                                    {
                                        name = "userName",
                                        type = "string",
                                        multiValued = false,
                                        description = "Unique userName. REQUIRED.",
                                        schema = Consts.DEFAULT_SCHEMA,
                                        readOnly = true,
                                        required = true,
                                        caseExact = false
                                    },
                                new SchemaAttributeModel
                                    {
                                        name = "externalId",
                                        type = "string",
                                        multiValued = false,
                                        description = "",
                                        schema = Consts.DEFAULT_SCHEMA,
                                        readOnly = true,
                                        required = false,
                                        caseExact = false
                                    },
                                new SchemaAttributeModel
                                    {
                                        name = "name",
                                        type = "complex",
                                        multiValued = false,
                                        description = "",
                                        schema = Consts.DEFAULT_SCHEMA,
                                        readOnly = true,
                                        required = false,
                                        caseExact = false
                                    },
                                new SchemaAttributeModel
                                    {
                                        name = "nickName",
                                        type = "string",
                                        multiValued = false,
                                        description = "",
                                        schema = Consts.DEFAULT_SCHEMA,
                                        readOnly = true,
                                        required = false,
                                        caseExact = false
                                    },
                                new SchemaAttributeModel
                                    {
                                        name = "profileUrl",
                                        type = "string",
                                        multiValued = false,
                                        description = "",
                                        schema = Consts.DEFAULT_SCHEMA,
                                        readOnly = true,
                                        required = false,
                                        caseExact = false
                                    }
                            }
                    };

            }

            return result;
        }
    }
}
