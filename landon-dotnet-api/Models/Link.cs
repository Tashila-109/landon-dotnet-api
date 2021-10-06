using System.ComponentModel;

namespace landon_dotnet_api.Models
{
    public class Link
    {
        private const string GetMethod = "GET";
        
        public string Href { get; set; }

        public string[] Relations { get; set; }

        [DefaultValue(GetMethod)]
        public string Method { get; set; }
    }
}