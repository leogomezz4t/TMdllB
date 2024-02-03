using System.Text.Json.Serialization;
using TMdllB.Objects;

namespace TMdllB.Details
{
    public class TvMovieBaseDetails
    {
        [JsonPropertyName("adult")]
        public bool IsAdult { get; set; }

        [JsonPropertyName("backdrop_path")]
        public string? RelativeBackdropPath { get; set; }

        public string? BackdropPath { get
            {
                if (RelativeBackdropPath == null)
                {
                    return null;
                }

                return $"{TMDbClient.IMAGE_BASE_URL}{TMDbClient.IMAGE_ORIGINAL_SIZE_ENDPOINT}{RelativeBackdropPath}";
            }
        }

        [JsonPropertyName("genres")]
        public Genre[] Genres { get; set;  }

        [JsonPropertyName("homepage")]
        public string Homepage { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonPropertyName("overview")]
        public string Overview { get; set; }

        [JsonPropertyName("popularity")]
        public float Popularity { get; set; }

        [JsonPropertyName("poster_path")]
        public string? RelativePosterPath { get; set; }

        public string? PosterPath { get
            {
                if (RelativePosterPath == null)
                {
                    return null;
                }

                return $"{TMDbClient.IMAGE_BASE_URL}{TMDbClient.IMAGE_ORIGINAL_SIZE_ENDPOINT}{RelativePosterPath}";
            } 
        }

        [JsonPropertyName("production_companies")]
        public ProductionCompany[] ProductionCompanies { get; set; }

        [JsonPropertyName("production_countries")]
        public ProductionCountry[] ProductionCountries { get; set; }

        [JsonPropertyName("spoken_languages")]
        public SpokenLanguage[] SpokenLanguages { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("tagline")] 
        public string Tagline { get; set; }

        [JsonPropertyName("vote_average")]
        public float VoteAverage { get; set; }

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }
    }
}
