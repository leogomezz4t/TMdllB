using System.Text.Json.Serialization;

namespace TMdllB.Objects
{
    public class ProductionCompany
    {
        [JsonPropertyName("id")]
        public int Id { get; }

        [JsonPropertyName("logo_path")]
        public string? RelativeLogoPath { get; }

        public string? LogoPath { get
            {
                if (RelativeLogoPath == null) return null;

                return $"{TMDbClient.IMAGE_BASE_URL}{TMDbClient.IMAGE_ORIGINAL_SIZE_ENDPOINT}{RelativeLogoPath}";
            }
        }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("origin_country")]
        public string OriginCountry { get; }
    }
}
