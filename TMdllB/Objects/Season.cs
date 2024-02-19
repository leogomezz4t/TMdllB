using System.Text.Json.Serialization;

namespace TMdllB.Objects
{
    public class Season
    {
        [JsonPropertyName("air_date")]
        public DateOnly? AirDate { get; set; }

        [JsonPropertyName("episode_count")]
        public int EpisodeCount { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("overview")]
        public string Overview { get; set; }

        [JsonPropertyName("poster_path")]
        public string RelativePosterPath { get; set; }

        public string PosterPath { get
            {
                return TMDbClient.GetOriginalImageUrl(RelativePosterPath);
            }
        }

        [JsonPropertyName("season_number")]
        public int SeasonNumber { get; set; }

        [JsonPropertyName("vote_average")]
        public float VoteAverage { get; set; }
    }
}
