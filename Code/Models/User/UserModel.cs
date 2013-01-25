using System;
using EnjoyDialogs.SCIM.Helpers;
using EnjoyDialogs.SCIM.Infrastructure;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EnjoyDialogs.SCIM.Models
{
    //[JsonConverter(typeof(UserModelCustomConverter))]
    public class UserModel : SchemaBaseModel
    {
        /// <summary>
        /// Unique identifier for the SCIM resource as defined by the Service Provider. 
        /// Each representation of the resource MUST include a non-empty id value. 
        /// This identifier MUST be unique across the Service Provider's entire set of resources. 
        /// It MUST be a stable, non-reassignable identifier that does not change when the same resource is returned in subsequent requests. 
        /// The value of the id attribute is always issued by the Service Provider and MUST never be specified by the Service Consumer. REQUIRED.
        /// </summary>
        [JsonProperty(Required = Required.AllowNull)]
        public Guid? Id { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string UserName { get; set; }

        public string ExternalId { get; set; }
        public NameModel[] Name { get; set; }
        public string DisplayName { get; set; }
        public string NickName { get; set; }
        public string ProfileUrl { get; set; }
        public EmailModel[] Emails { get; set; }
        public AddressModel[] Addresses { get; set; }
        public PhoneNumberModel[] PhoneNumbers { get; set; }
        public InstantMessagingModel[] Ims { get; set; }
        public PhotoModel[] Photos { get; set; }
        public string UserType { get; set; }
        public string Title { get; set; }
        public string PreferredLanguage { get; set; }
        public string Locale { get; set; }
        public string Timezonoe { get; set; }
        public bool Active { get; set; }
        public string Password { get; set; }
        public GroupMembershipModel[] Groups { get; set; }
        public x509CertificateModel[] X509Certificates { get; set; }
        public MetaModel Meta { get; set; }

    }

    public class EnterpriseUserModel : UserModel
    {
        public EnterpriseUserModel EnterpriseUser { get; set; }
    }

    //[JsonConverter(typeof(UserModelCustomConverter))]
    //internal class UserModelCustomConverter : JsonCreationConverter<UserModel>
    //{
    //    protected override UserModel Create(Type objectType, JObject jObject)
    //    {
    //        //TODO: read the raw JSON object through jObject to identify the type
    //        //e.g. here I'm reading a 'typename' property:

    //        return "EnterpriseUserModel".Equals(jObject.Value<string>("typename")) ? new EnterpriseUserModel() : new UserModel();
    //    }
    //}
}