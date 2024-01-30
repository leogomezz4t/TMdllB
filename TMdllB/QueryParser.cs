using System.Text.Json;

namespace TMdllB
{
    public static class QueryParser
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
    }
}
