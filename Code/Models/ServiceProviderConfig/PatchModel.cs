

using System.ComponentModel.DataAnnotations;

namespace EnjoyDialogs.SCIM.Models
{
    public class PatchModel
    {
        /// <summary>
        /// Boolean value specifying whether the operation is supported.
        /// </summary>
        [Required]
        public bool supported { get { return false; } }
    }

}