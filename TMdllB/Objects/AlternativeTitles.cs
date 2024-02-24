using System.Text.Json.Serialization;

namespace TMdllB.Objects
{
    public class AlternativeTitles
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("titles")]
        public AlternativeTitle[] Titles { get; set; }
    }
}
