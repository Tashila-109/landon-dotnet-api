using System.Text.Json.Serialization;

namespace landon_dotnet_api.Models
{
    public abstract class Resource
    {
        public string Href { get; set; }
    }
}