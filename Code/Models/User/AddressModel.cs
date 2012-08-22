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
        public string Type { get; set; }
        /// <summary>
        /// The full street address component, which may include house number, street name, PO BOX, and multi-line extended street address information. This attribute MAY contain newlines.
        /// </summary>
        public string StreetAddress { get; set; }
        /// <summary>
        /// The city or locality component.
        /// </summary>
        public string Locality { get; set; }
        /// <summary>
        /// The state or region component.
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// The zipcode or postal code component.
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// The country name component.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The full mailing address, formatted for display or use with a mailing label. This attribute MAY contain newlines.
        /// </summary>
        public string Formatted
        {
            get
            {
                var result = string.Format("{0}\n{1} - {2} {3} {4}",
                                           StreetAddress,
                                           Country,
                                           PostalCode,
                                           Region,
                                           Locality
                    );
                return result.Replace("  ", " ");
            }
        }

        public bool Primary { get; set; }
    }
   
}