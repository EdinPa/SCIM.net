

using System.ComponentModel.DataAnnotations;

namespace EnjoyDialogs.SCIM.Models
{
    public class BulkModel
    {
        /// <summary>
        /// Boolean value specifying whether the operation is supported.
        /// </summary>
        [Required]
        public bool supported { get { return false; } }

        /// <summary>
        /// An integer value specifying the maximum number of operations.
        /// </summary>
        [Required]
        public int maxOperations { get; set; }

        /// <summary>
        /// An integer value specifying the maximum payload size in bytes.
        /// </summary>
        [Required]
        public int maxPayloadSize { get; set; }
    }
}