

using System.ComponentModel.DataAnnotations;

namespace EnjoyDialogs.SCIM.Models
{
    public class AuthenticationScheme
    {
        /// <summary>
        /// The common authentication scheme name; e.g., HTTP Basic.
        /// </summary>
        [Required]
        public string name { get; set; }
        /// <summary>
        /// A description of the Authentication Scheme.
        /// </summary>
        [Required]
        public string description { get; set; }
        /// <summary>
        /// A HTTP addressable URL pointing to the Authentication Scheme's specification.
        /// </summary>
        public string specUrl { get; set; }
        /// <summary>
        /// A HTTP addressable URL pointing to the Authentication Scheme's usage documentation
        /// </summary>
        public string documentationUrl { get; set; }

        public string type { get; set; }
        public bool primary { get; set; }
    }
}