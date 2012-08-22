
namespace EnjoyDialogs.SCIM.Models
{
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    public class BulkModel
    {
        /// <summary>
        /// Boolean value specifying whether the operation is Supported.
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public bool Supported { get { return false; } }

        /// <summary>
        /// An integer value specifying the maximum number of operations.
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public int MaxOperations { get; set; }

        /// <summary>
        /// An integer value specifying the maximum payload size in bytes.
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public int MaxPayloadSize { get; set; }
    }
}