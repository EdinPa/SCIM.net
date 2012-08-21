

using System.ComponentModel.DataAnnotations;

namespace EnjoyDialogs.SCIM.Models
{
    public class FilterModel
    {
        /// <summary>
        /// Boolean value specifying whether the operation is supported.
        /// </summary>
        [Required]
        public bool supported { get { return true; } }

        /// <summary>
        /// Integer value specifying the maximum number of Resources returned in a response
        /// </summary>
        [Required]
        public int maxResults { get; set; }
    }
}