using System.ComponentModel;
using System.Text.Json.Serialization;

namespace landon_dotnet_api.Models
{
    public class Link
    {
        private const string GetMethod = "GET";

        public static Link To(string routeName, object routeValues = null) => new Link
        {
            RouteName = routeName,
            RouteValues = routeValues,
            Method = GetMethod,
            Relations = null
        };
        
        public string Href { get; set; }

        public string[] Relations { get; set; }

        [DefaultValue(GetMethod)]
        public string Method { get; set; }
        
        // Stores the route name before being rewritten by the LinkRewritingFilter
        [JsonIgnore]
        public string RouteName { get; set; }
        
        // Stores the route parameters before being rewritten by the LinkRewritingFilter
        [JsonIgnore]
        public object RouteValues { get; set; }
    }
}