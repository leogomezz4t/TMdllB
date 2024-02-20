
using System.Text.Json.Serialization;
using TMdllB.Objects;

namespace TMdllB.Details
{
    public class TVDetails : TvMovieBaseDetails
    {
        [JsonPropertyName("created_by")]
        public Creator[] CreatedBy { get; set; }

        //[JsonPropertyName("episode_run_time")]
        // Not sure what typa value goes here

        [JsonPropertyName("first_air_date")]
        public DateOnly FirstAirDate { get; set; }

        [JsonPropertyName("in_production")]
        public bool InProduction { get; set; }

        [JsonPropertyName("languages")]
        public string[] Languages { get; set; }

        [JsonPropertyName("last_air_date")]
        public DateOnly LastAirDate { get; set; }

        [JsonPropertyName("last_episode_to_air")]
        public Episode? LastEpisodeToAir { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("next_episode_to_air")]
        public Episode? NextEpisodeToAir { get; set; }

        [JsonPropertyName("networks")]
        public Network[] Networks { get; set; }

        [JsonPropertyName("number_of_episodes")]
        public int NumberOfEpisodes { get; set; }

        [JsonPropertyName("number_of_seasons")]
        public int NumberOfSeasons { get; set; }

        [JsonPropertyName("origin_country")]
        public string[] OriginCountries { get; set; }

        [JsonPropertyName("original_name")]
        public string OriginalName { get; set; }

        [JsonPropertyName("seasons")]
        public Season[] Seasons { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
