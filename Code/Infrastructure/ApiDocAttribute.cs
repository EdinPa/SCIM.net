using System;

namespace EnjoyDialogs.SCIM.Infrastructure
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ApiDocAttribute : Attribute
    {
        public ApiDocAttribute(string doc)
        {
            Documentation = doc;
        }
        public string Documentation { get; set; }
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class ApiParameterDocAttribute : Attribute
    {
        public ApiParameterDocAttribute(string param, string doc, Type type)
        {
            Parameter = param;
            Documentation = doc;
            ResultType = type;
        }
        public string Parameter { get; set; }
        public string Documentation { get; set; }
        public Type ResultType { get; set; }
    }
}