using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace EnjoyDialogs.SCIM
{
    public static class FormatingConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            // Convert all dates to UTC 
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc;
            json.SerializerSettings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat;
            json.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}