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

        public static MovieContainer ParseMovieResults(string json)
        {
            MovieContainer mc = JsonSerializer.Deserialize<MovieContainer>(json, _serializeOptions);

            return mc;
        }
    }
}
