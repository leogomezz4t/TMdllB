using System.Text.Json.Serialization;
using TMdllB.Objects;

namespace TMdllB.Details
{
    public class MovieDetails : TvMovieBaseDetails
    {
        [JsonPropertyName("belongs_to_collection")]
        public Collection? BelongsToCollection { get; set; }

        [JsonPropertyName("budget")]
        public int Budget { get; set; }

        [JsonPropertyName("imdb_id")]
        public string ImdbId { get; set; }

        [JsonPropertyName("original_title")]
        public string OriginalTitle { get; set; }

        [JsonPropertyName("release_date")] 
        public DateOnly ReleaseDate { get; set; }

        [JsonPropertyName("revenue")]
        public int Revenue { get; set; }

        [JsonPropertyName("runtime")]
        public int Runtime { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("video")]
        public bool HasVideo { get; set; }
    }
}
