using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnjoyDialogs.SCIM.Models
{
    /// <summary>
    /// A physical mailing address for this User, as described in (address Element). Canonical Type Values of work, home, and other. The value attribute is a complex type with the following sub-attributes.
    /// </summary>
    public class AddressModel
    {
        /// <summary>
        /// A label indicating the attribute's function; e.g., 'work' or 'home'.
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// The full street address component, which may include house number, street name, PO BOX, and multi-line extended street address information. This attribute MAY contain newlines.
        /// </summary>
        public string streetAddress { get; set; }
        /// <summary>
        /// The city or locality component.
        /// </summary>
        public string locality { get; set; }
        /// <summary>
        /// The state or region component.
        /// </summary>
        public string region { get; set; }
        /// <summary>
        /// The zipcode or postal code component.
        /// </summary>
        public string postalCode { get; set; }
        /// <summary>
        /// The country name component.
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// The full mailing address, formatted for display or use with a mailing label. This attribute MAY contain newlines.
        /// </summary>
        public string formatted
        {
            get
            {
                var result = string.Format("{0}\n{1} - {2} {3} {4}",
                                           streetAddress,
                                           country,
                                           postalCode,
                                           region,
                                           locality
                    );
                return result.Replace("  ", " ");
            }
        }

        public bool primary { get; set; }
    }
   
}