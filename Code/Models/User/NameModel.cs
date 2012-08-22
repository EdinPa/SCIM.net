
namespace EnjoyDialogs.SCIM.Models
{
    /// <summary>
    /// The components of the user's real name. Providers MAY return just the full name as a single string in the formatted sub-attribute, or they MAY return just the individual component attributes using the other sub-attributes, or they MAY return both. If both variants are returned, they SHOULD be describing the same name, with the formatted name indicating how the component attributes should be combined.
    /// </summary>
    public class NameModel
    {
        /// <summary>
        /// The full name, including all middle names, titles, and suffixes as appropriate, formatted for display (e.g. Ms. Barbara J Jensen, III.).
        /// </summary>
        public string Formatted
        {
            get
            {
                var result = string.Format("{0} {1} {2} {3} {4}",
                                           HonorificPrefix,
                                           GivenName,
                                           MiddleName,
                                           FamilyName,
                                           HonorificSuffix
                    );
                return result.Replace("  ", " ");
            }
        }

        /// <summary>
        /// The family name of the User, or Last Name in most Western languages (e.g. Jensen given the full name Ms. Barbara J Jensen, III.).
        /// </summary>
        public string FamilyName { get; set; }

        /// <summary>
        /// The given name of the User, or First Name in most Western languages (e.g. Barbara given the full name Ms. Barbara J Jensen, III.).
        /// </summary>
        public string GivenName { get; set; }
        /// <summary>
        /// The middle name(s) of the User (e.g. Robert given the full name Ms. Barbara J Jensen, III.).
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// The honorific prefix(es) of the User, or Title in most Western languages (e.g. Ms. given the full name Ms. Barbara J Jensen, III.).
        /// </summary>
        public string HonorificPrefix { get; set; }
        /// <summary>
        /// The honorific suffix(es) of the User, or Suffix in most Western languages (e.g. III. given the full name Ms. Barbara J Jensen, III.).
        /// </summary>
        public string HonorificSuffix { get; set; }
    }

}