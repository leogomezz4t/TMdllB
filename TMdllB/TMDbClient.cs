using System.Web;
using TMdllB.Query;
using TMdllB.SearchResults;

namespace TMdllB
{
    // **** Constants


    public class TMDbClient
    {
        public TMDbClient(string apiKey)
        {
            API_KEY = apiKey;
        }

        // **** Class Constants
        internal static string IMAGE_BASE_URL = "https://image.tmdb.org/t/p";
        internal static string IMAGE_ORIGINAL_SIZE_ENDPOINT = "/original";
        internal static string IMAGE_W500_SIZE_ENDPOINT = "/w500";

        internal static string API_BASE_URL = "https://api.themoviedb.org/3";
        internal static string API_SEARCH = "/search";
        internal static string API_MOVIES = "/movie";
        internal static string API_TV_SERIES = "/tv";

        // **** Properties

        private string API_KEY;

        // **** Methods
        public async Task<List<Movie>> SearchMovies(string query)
        {
            // Url Encode the get params
            string encodedQuery = HttpUtility.UrlEncode(query);
            // Construct the url
            string url = $"{API_BASE_URL}{API_SEARCH}{API_MOVIES}?api_key={API_KEY}&query={encodedQuery}";
            // Get string result from the url
            string jsonResult = await QueryAPI.GetString(url);
            // Serialize the jsonResult
            MovieResultContainer container = QueryParser.ParseMovieResults(jsonResult);
            // Convert all results to a Movie
            List<Movie> movies = container.Results.Select(x => new Movie(x, this)).ToList();

            return movies;
        }
    }
}