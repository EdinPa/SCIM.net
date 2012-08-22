
using Newtonsoft.Json;

namespace EnjoyDialogs.SCIM.Models
{
    public abstract class SchemaBaseModel
    {
        [JsonProperty(Required = Required.Always, Order = 0)]
        public string[] Schemas
        {
            get { return new[] { Consts.DEFAULT_SCHEMA }; }
        }

    }
}