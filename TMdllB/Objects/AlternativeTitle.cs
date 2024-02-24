using System.Text.Json.Serialization;

namespace TMdllB.Objects
{
    public class AlternativeTitle
    {
        [JsonPropertyName("iso_3166_1")]
        public string Iso3166_1 { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
