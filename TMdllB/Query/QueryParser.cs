using System.Text.Json;
using TMdllB.SearchResults;

namespace TMdllB.Query
{
    internal static class QueryParser
    {
        // **** Static Properties
        private static readonly JsonSerializerOptions _serializeOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };

        public static MovieResultContainer ParseMovieResults(string json)
        {
            MovieResultContainer? mc = JsonSerializer.Deserialize<MovieResultContainer>(json, _serializeOptions);

            // Check for null types
            if (mc == null) throw new Exception($"Failed to deserialize the input: {json}");

            return mc;
        }

        public static TVResultContainer ParseTVResults(string json)
        {
            TVResultContainer? tc = JsonSerializer.Deserialize<TVResultContainer>(json, _serializeOptions);

            // check for null
            if (tc == null) throw new Exception($"Failed to deserialize the input: {json}");

            return tc;
        }
    }
}
