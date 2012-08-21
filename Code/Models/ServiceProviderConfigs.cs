

namespace EnjoyDialogs.SCIM.Models
{
    public class ServiceProviderConfigsModel : SchemaBaseModel
    {
        public string documentationUrl { get; set; }
        public PatchModel patch { get; set; }
        public BulkModel bulk { get; set; }
        public FilterModel filter { get; set; }
        public ChangePasswordModel changePassword { get; set; }
        public SortModel sort { get; set; }
        public EtagModel etag { get; set; }
        public XmlDataFormatModel xmlDataFormat { get; set; }
        public AuthenticationScheme[] authenticationSchemes { get; set; }
    }

    public class PatchModel
    {
        public bool supported { get { return false; } }
    }

    public class BulkModel
    {
        public bool supported { get { return false; } }
        public int maxOperations { get; set; }
        public int maxPayloadSize { get; set; }
    }

    public class FilterModel
    {
        public bool supported { get { return false; } }
        public int maxResults { get; set; }
    }

    public class ChangePasswordModel
    {
        public bool supported { get { return false; } }
    }
    
    public class SortModel
    {
        public bool supported { get { return false; } }
    }

    public class EtagModel
    {
        public bool supported { get { return true; } }
    }

    public class XmlDataFormatModel
    {
        public bool supported { get; set; }
    }

    public class AuthenticationScheme
    {
        public string name { get; set; }
        public string description { get; set; }
        public string specUrl { get; set; }
        public string documentationUrl { get; set; }
        public string type { get; set; }
        public bool primary { get; set; }
    }
}