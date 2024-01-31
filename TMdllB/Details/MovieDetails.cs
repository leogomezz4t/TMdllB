using System.Text.Json.Serialization;
using TMdllB.Objects;

namespace TMdllB.Details
{
    public class MovieDetails : TvMovieBaseDetails
    {
        [JsonPropertyName("belongs_to_collection")]
        public Collection? BelongsToCollection { get; }

        [JsonPropertyName("budget")]
        public int Budget { get; }

        [JsonPropertyName("imdb_id")]
        public string ImdbId { get; }

        [JsonPropertyName("original_title")]
        public string OriginalTitle { get; }

        [JsonPropertyName("release_date")] 
        public DateOnly ReleaseDate { get; }

        [JsonPropertyName("revenue")]
        public int Revenue { get; }

        [JsonPropertyName("runtime")]
        public int Runtime { get; }

        [JsonPropertyName("title")]
        public string Title { get; }

        [JsonPropertyName("video")]
        public bool HasVideo { get; }
    }
}
