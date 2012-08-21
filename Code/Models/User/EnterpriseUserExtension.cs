using System;

namespace EnjoyDialogs.SCIM.Code.Models
{
    public class EnterpriseUserExtension
    {
        /// <summary>
        /// Numeric or alphanumeric identifier assigned to a person, typically based on order of hire or association with an organization.
        /// </summary>
        public string employeeNumber { get; set; }
        public string costCenter { get; set; }
        public string organization { get; set; }
        public string division { get; set; }
        public string department { get; set; }
        public ManagerModel[] manager { get; set; }
    }

    public class ManagerModel
    {
        public Guid managerId { get; set; }
        public string displayName { get; set; }
    }
}