
using Newtonsoft.Json;

namespace EnjoyDialogs.SCIM.Models
{
    public class SchemaModel 
    {
        [JsonProperty(Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }
        
        public string Description { get; set; }
        public string Schema { get; set; }
        public string Endpoint { get; set; }
        public SchemaAttributeModel[] Attributes { get; set; }
    }

    public class SchemaAttributeModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool MultiValued { get; set; }
        public string Description { get; set; }
        public string Schema { get; set; }
        public bool ReadOnly { get; set; }
        public bool Required { get; set; }
        public bool CaseExact { get; set; }

        public SchemaAttributeModel[] SubAttributes { get; set; }
    }
}