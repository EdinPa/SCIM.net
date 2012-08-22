
namespace EnjoyDialogs.SCIM.Models
{
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    public class FilterModel
    {
        /// <summary>
        /// Boolean value specifying whether the operation is supported.
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public bool Supported { get { return true; } }

        /// <summary>
        /// Integer value specifying the maximum number of Resources returned in a response
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public int MaxResults { get; set; }
    }
}