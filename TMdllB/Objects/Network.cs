using System.Text.Json.Serialization;

namespace TMdllB.Objects
{
    public class Network
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("logo_path")]
        public string RelativeLogoPath { get; set; }

        public string LogoPath { get
            {
                return TMDbClient.GetOriginalImageUrl(RelativeLogoPath);
            }
        }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("origin_country")]
        public string OriginCountry { get; set; }
    }
}
