using System;

namespace EnjoyDialogs.SCIM.Models
{
    public class GroupModel : SchemaBaseModel
    {
        public Guid id { get; set; }
        public string displayName { get; set; }
        public GroupMemberModel[] members { get; set; }
    }
}