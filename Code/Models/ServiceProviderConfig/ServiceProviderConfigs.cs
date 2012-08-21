

using System.ComponentModel.DataAnnotations;

namespace EnjoyDialogs.SCIM.Models
{
    /// <summary>
    /// The Service Provider Configuration Resource enables a Service Provider to expose its compliance with the SCIM specification 
    /// in a standardized form as well as provide additional implementation details to Consumers.
    /// </summary>
    public class ServiceProviderConfigModel : SchemaBaseModel
    {
        /// <summary>
        /// An HTTP addressable URL pointing to the Service Provider's human consumable help documentation.
        /// </summary>
        public string documentationUrl { get; set; }

        /// <summary>
        /// A complex type that specifies PATCH configuration options.
        /// </summary>
        [Required]
        public PatchModel patch { get; set; }

        /// <summary>
        /// A complex type that specifies BULK configuration options
        /// </summary>
        [Required]
        public BulkModel bulk { get; set; }

        /// <summary>
        /// A complex type that specifies FILTER options.
        /// </summary>
        [Required]
        public FilterModel filter { get; set; }

        /// <summary>
        ///  A complex type that specifies Change Password configuration options.
        /// </summary>
        [Required]
        public ChangePasswordModel changePassword { get; set; }

        /// <summary>
        /// A complex type that specifies Sort configuration options.
        /// </summary>
        [Required]
        public SortModel sort { get; set; }

        /// <summary>
        /// A complex type that specifies Etag configuration options.
        /// </summary>
        [Required]
        public EtagModel etag { get; set; }

        /// <summary>
        /// A complex type that specifies whether the XML data format is supported.
        /// </summary>
        [Required]
        public XmlDataFormatModel xmlDataFormat { get; set; }

        /// <summary>
        /// A complex type that specifies supported Authentication Scheme properties.  Instead of the standard Canonical Values for type, 
        /// this attribute defines the following Canonical Values to represent common schemes: oauth, oauth2, oauthbearertoken, httpbasic, and httpdigest.  
        /// To enable seamless discovery of configuration, the Service Provider SHOULD, with the appropriate security considerations, 
        /// make the authenticationSchemes attribute publicly accessible without prior authentication.
        /// </summary>
        [Required]
        public AuthenticationScheme[] authenticationSchemes { get; set; }
    }
}