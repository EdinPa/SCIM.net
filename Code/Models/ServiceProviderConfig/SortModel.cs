

using System.ComponentModel.DataAnnotations;

namespace EnjoyDialogs.SCIM.Models
{
    public class SortModel
    {
        /// <summary>
        /// Boolean value specifying whether the operation is supported.
        /// </summary>
        [Required]
        public bool supported { get { return true; } }
    }

}