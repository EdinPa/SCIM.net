
namespace EnjoyDialogs.SCIM.Models
{
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    public class SortModel
    {
        /// <summary>
        /// Boolean value specifying whether the operation is supported.
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public bool Supported { get { return true; } }
    }

}