using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebApplication2.Model
{
    public class ZimProduct
    {
        public string id { get; set; }
        public string maker { get; set; }
        [JsonPropertyName("img")]
        public string image { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int[] rating{get; set;}
        public override string ToString() => JsonSerializer.Serialize<ZimProduct>(this);
    }
}
