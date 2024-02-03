using System.Text.Json.Serialization;

namespace TMdllB.Objects
{
    public class Genre
    {
        [JsonPropertyName("id")]
        public int Id { get; set;  }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
