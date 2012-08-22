
using System.Net;

namespace EnjoyDialogs.SCIM.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ErrorModel
    {
        public ErrorModel()
        {
            this.Errors = new List<ErrorDetailModel>();
        }
        [JsonProperty(Required = Required.Always)]
        public IList<ErrorDetailModel> Errors { get; set; }
    }

    public class ErrorDetailModel
    {
        public HttpStatusCode Code { get; set; }
        public string Description { get; set; }
    }
}