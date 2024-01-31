using System.Text.Json.Serialization;

namespace TMdllB.Objects
{
    public class SpokenLanguage
    {
        [JsonPropertyName("english_name")]
        public string EnglishName { get; }

        [JsonPropertyName("iso_639_1")]
        public string Iso639_1 { get; }

        [JsonPropertyName("name")]
        public string Name { get; }
    }
}
