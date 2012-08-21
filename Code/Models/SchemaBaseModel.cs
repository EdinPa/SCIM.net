
namespace EnjoyDialogs.SCIM.Models
{
    public abstract class SchemaBaseModel
    {
        public string[] schemas
        {
            get { return new[] { Consts.DEFAULT_SCHEMA }; }
        }

    }
}