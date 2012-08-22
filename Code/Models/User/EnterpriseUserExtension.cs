using System;

namespace EnjoyDialogs.SCIM.Code.Models
{
    public class EnterpriseUserExtension
    {
        /// <summary>
        /// Numeric or alphanumeric identifier assigned to a person, typically based on order of hire or association with an organization.
        /// </summary>
        public string EmployeeNumber { get; set; }
        public string CostCenter { get; set; }
        public string Organization { get; set; }
        public string Division { get; set; }
        public string Department { get; set; }
        public ManagerModel[] Manager { get; set; }
    }

    public class ManagerModel
    {
        public Guid ManagerId { get; set; }
        public string DisplayName { get; set; }
    }
}