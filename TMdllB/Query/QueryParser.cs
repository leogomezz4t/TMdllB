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
            MovieResultContainer mc = JsonSerializer.Deserialize<MovieResultContainer>(json, _serializeOptions);

            return mc;
        }

        public static TVResultContainer ParseTVResults(string json)
        {
            TVResultContainer tc = JsonSerializer.Deserialize<TVResultContainer>(json, _serializeOptions);

            return tc;
        }
    }
}
