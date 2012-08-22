
namespace EnjoyDialogs.SCIM.Models
{
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    public class AuthenticationScheme
    {
        /// <summary>
        /// The common authentication scheme name; e.g., HTTP Basic.
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }

        /// <summary>
        /// A description of the Authentication Scheme.
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string Description { get; set; }

        /// <summary>
        /// A HTTP addressable URL pointing to the Authentication Scheme's specification.
        /// </summary>
        public string SpecUrl { get; set; }

        /// <summary>
        /// A HTTP addressable URL pointing to the Authentication Scheme's usage documentation
        /// </summary>
        public string DocumentationUrl { get; set; }

        public string Type { get; set; }
        public bool Primary { get; set; }
    }
}