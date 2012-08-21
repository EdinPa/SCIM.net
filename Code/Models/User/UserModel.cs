using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnjoyDialogs.SCIM.Models
{
    public class UserModel : SchemaBaseModel
    {
        /// <summary>
        /// Unique identifier for the SCIM resource as defined by the Service Provider. 
        /// Each representation of the resource MUST include a non-empty id value. 
        /// This identifier MUST be unique across the Service Provider's entire set of resources. 
        /// It MUST be a stable, non-reassignable identifier that does not change when the same resource is returned in subsequent requests. 
        /// The value of the id attribute is always issued by the Service Provider and MUST never be specified by the Service Consumer. REQUIRED.
        /// </summary>
        public Guid id { get; set; }
        public string userName { get; set; }

        public string externalId { get; set; }
        public NameModel[] name { get; set; }
        public string displayName { get; set; }
        public string nickName { get; set; }
        public string profileUrl { get; set; }
        public EmailModel[] emails { get; set; }
        public AddressModel[] addresses { get; set; }
        public PhoneNumberModel[] phoneNumbers { get; set; }
        public InstantMessagingModel[] ims { get; set; }
        public PhotoModel[] photos { get; set; }
        public string userType { get; set; }
        public string title { get; set; }
        public string preferredLanguage { get; set; }
        public string locale { get; set; }
        public string timezonoe { get; set; }
        public bool active { get; set; }
        public string password { get; set; }
        public GroupMembershipModel[] groups { get; set; }
        public x509CertificateModel[] x509Certificates { get; set; }
        public MetaModel meta { get; set; }
    }

    public class EnterpriseUserModel : UserModel
    {
        
        public EnterpriseUserModel EnterpriseUser { get; set; }
    }
}