
using System.Text.Json.Serialization;
using TMdllB.Objects;

namespace TMdllB.Details
{
    public class TvDetails
    {
        [JsonPropertyName("created_by")]
        public Creator[] CreatedBy { get; set; }

        //[JsonPropertyName("episode_run_time")]
        // Not sure what typa value goes here

        [JsonPropertyName("first_air_date")]
        public DateOnly FirstAirDate { get; set; }

        [JsonPropertyName("in_production")
        public bool InProduction { get; set; }

        [JsonPropertyName("languages")]
        public string[] Languages { get; set; }

        [JsonPropertyName("last_air_date")]
        public DateOnly LastAirDate { get; set; }

        [JsonPropertyName("last_episode_to_air")]
        public Episode LastEpisodeToAir { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("next_episode_to_air")]
        public Episode? NextEpisodeToAir { get; set; }


    }
}
