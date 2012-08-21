
namespace EnjoyDialogs.SCIM.Models
{
  
    /// <summary>
    /// E-mail addresses for the user. The value SHOULD be canonicalized by the Service Provider, e.g. bjensen@example.com instead of bjensen@EXAMPLE.COM. Canonical Type values of work, home, and other.
    /// </summary>
    public class EmailModel
    {
        /// <summary>
        /// A human readable name, primarily used for display purposes. READ-ONLY.
        /// </summary>
        public string display { get { return value; } }

        /// <summary>
        /// E-mail addresses for the user. The value SHOULD be canonicalized by the Service Provider, e.g. bjensen@example.com instead of bjensen@EXAMPLE.COM. Canonical Type values of work, home, and other.
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// A label indicating the attribute's function; e.g., 'work' or 'home'.
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// A Boolean value indicating the 'primary' or preferred attribute value for this attribute, e.g. the preferred mailing address or primary e-mail address. The primary attribute value 'true' MUST appear no more than once.
        /// </summary>
        public bool primary { get; set; }
    }

}