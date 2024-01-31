using System.Text.Json.Serialization;
using TMdllB.Objects;

namespace TMdllB.Details
{
    public class TvMovieBaseDetails
    {
        [JsonPropertyName("adult")]
        public bool IsAdult { get; }

        [JsonPropertyName("backdrop_path")]
        public string? RelativeBackdropPath { get; }

        public string? BackdropPath { get
            {
                if (RelativeBackdropPath == null)
                {
                    return null
                }

                return $"{TMDbClient.IMAGE_BASE_URL}{TMDbClient.IMAGE_ORIGINAL_SIZE_ENDPOINT}{RelativeBackdropPath}";
            }
        }

        [JsonPropertyName("genres")]
        public Genre[] Genres { get; }

        [JsonPropertyName("homepage")]
        public string Homepage { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("original_language")]
        public string OriginalLanguage { get; }

        [JsonPropertyName("overview")]
        public string Overview { get; }

        [JsonPropertyName("popularity")]
        public float Popularity { get; }

        [JsonPropertyName("poster_path")]
        public string? RelativePosterPath { get; }

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
        public ProductionCompany[] ProductionCompanies { get; }

        [JsonPropertyName("production_countries")]
        public ProductionCountry[] ProductionCountries { get; }

        [JsonPropertyName("spoken_languages")]
        public SpokenLanguage[] SpokenLanguages { get; }

        [JsonPropertyName("status")]
        public string Status { get; }

        [JsonPropertyName("tagline")] 
        public string Tagline { get; }

        [JsonPropertyName("vote_average")]
        public float VoteAverage { get; }

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; }
    }
}
