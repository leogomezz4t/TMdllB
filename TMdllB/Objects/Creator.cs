using System.Text.Json.Serialization;

namespace TMdllB.Objects
{
    public class Creator
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("credit_id")]
        public string CreditId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        [JsonPropertyName("profile_path")]
        public string RelativeProfilePath { get; set; }

        public string ProfilePath { get
            {
                return $"{TMDbClient.IMAGE_BASE_URL}{TMDbClient.IMAGE_ORIGINAL_SIZE_ENDPOINT}{RelativeProfilePath}";
            } }
    }
}
