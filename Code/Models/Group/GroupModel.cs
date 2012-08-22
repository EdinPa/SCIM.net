
namespace EnjoyDialogs.SCIM.Models
{
    using System;
    using Newtonsoft.Json;

    public class GroupModel : SchemaBaseModel
    {
        [JsonProperty(Required = Required.Always)]
        public Guid Id { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string DisplayName { get; set; }


        public GroupMemberModel[] Members { get; set; }
    }
}