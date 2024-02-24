using System.Text.Json;
using TMdllB.Details;
using TMdllB.Exceptions;
using TMdllB.Objects;
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
            if (tc == null) throw new DeserializationFailureException(json);

            return tc;
        }

        public static MovieDetails ParseMovieDetails(string json)
        {
            MovieDetails? md = JsonSerializer.Deserialize<MovieDetails>(json, _serializeOptions);

            // Check null
            if (md == null) throw new DeserializationFailureException(json);

            return md;
        }

        public static TVDetails ParseTVDetails(string json)
        {
            TVDetails? td = JsonSerializer.Deserialize<TVDetails>(json, _serializeOptions);

            // Check null
            if (td == null) throw new DeserializationFailureException(json);

            return td;
        }

        public static AlternativeTitles ParseAlternativeTitles(string json)
        {
            AlternativeTitles? at = JsonSerializer.Deserialize<AlternativeTitles>(json, _serializeOptions);

            if (at == null) throw new DeserializationFailureException(json);

            return at;
        }
    }
}
