using System.Web;

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
        private static string API_BASE_URL = "https://api.themoviedb.org/3";
        private static string API_SEARCH = "/search";
        private static string API_MOVIES = "/movie";
        private static string API_TV_SERIES = "/tv";

        // **** Properties

        private string API_KEY;

        // **** Methods
        public async Task<MovieResultContainer> SearchMovies(string query)
        {
            // Url Encode the get params
            string encodedQuery = HttpUtility.UrlEncode(query);
            // Construct the url
            string url = $"{API_BASE_URL}{API_SEARCH}{API_MOVIES}?api_key={API_KEY}&query={encodedQuery}";
            // Get string result from the url
            string jsonResult = await QueryAPI.GetString(url);
            // ------ TODO Make sure the result is succesful
            // Serialize the jsonResult
            MovieResultContainer container = QueryParser.ParseMovieResults(jsonResult);

            return container;
        }
    }
}