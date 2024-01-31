using System.Text.Json.Serialization;

namespace TMdllB.Objects
{
    public class Collection
    {
        [JsonPropertyName("id")]
        public int Id { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("poster_path")]
        public string RelativePosterPath { get; }

        public string PosterPath { get {
                return $"{TMDbClient.IMAGE_BASE_URL}{TMDbClient.IMAGE_ORIGINAL_SIZE_ENDPOINT}{RelativePosterPath}";

            }
        }

        [JsonPropertyName("backdrop_path")]
        public string RelativeBackdropPath { get; }

        public string BackdropPath { get
            {
                return $"{TMDbClient.IMAGE_BASE_URL}{TMDbClient.IMAGE_ORIGINAL_SIZE_ENDPOINT}{RelativeBackdropPath}";
            }
        }
    }
}
