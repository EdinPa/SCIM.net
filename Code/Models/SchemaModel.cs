
namespace EnjoyDialogs.SCIM.Models
{
    public class SchemaModel 
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string schema { get; set; }
        public string endpoint { get; set; }
        public SchemaAttributeModel[] attributes { get; set; }
    }

    public class SchemaAttributeModel
    {
        public string name { get; set; }
        public string type { get; set; }
        public bool multiValued { get; set; }
        public string description { get; set; }
        public string schema { get; set; }
        public bool readOnly { get; set; }
        public bool required { get; set; }
        public bool caseExact { get; set; }

        public SchemaAttributeModel[] subAttributes { get; set; }
    }
}