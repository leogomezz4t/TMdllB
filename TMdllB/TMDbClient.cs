using System.Web;
using TMdllB.Query;
using TMdllB.SearchResults;
using TMdllB.Details;

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

        // **** Internal Methods
        internal static string GetOriginalImageUrl(string relPath)
        {
            return $"{IMAGE_BASE_URL}{IMAGE_ORIGINAL_SIZE_ENDPOINT}{relPath}";
        }

        // **** Methods
        public async Task<MovieResultContainer> SearchMovies(string query)
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
            //List<Movie> movies = container.Results.Select(x => new Movie(x, this)).ToList();

            return container;
        }

        public async Task<TVResultContainer> SearchTV(string query)
        {
            // Url encode the params
            string encodedQuery = HttpUtility.UrlEncode(query);
            // construct the url
            string url = $"{API_BASE_URL}{API_SEARCH}{API_TV_SERIES}?api_key={API_KEY}&query={encodedQuery}";
            // get the json in a string
            string jsonResult = await QueryAPI.GetString(url);
            // Serialize the string
            TVResultContainer container = QueryParser.ParseTVResults(jsonResult);

            return container;
        }

        public async Task<MovieDetails> GetMovieDetails(int id)
        {
            // No need to encode the id. Assuming it is an int representation in proper form
            string url = $"{API_BASE_URL}{API_MOVIES}/{id}?api_key={API_KEY}";
            string jsonResult = await QueryAPI.GetString(url);
            // serialize into a detail object
            MovieDetails md = QueryParser.ParseMovieDetails(jsonResult);

            return md;
        }

        public async Task<TVDetails> GetTVDetails(int id)
        {
            // No need to encode id
            string url = $"{API_BASE_URL}{API_TV_SERIES}/{id}?api_key={API_KEY}";
            string jsonResult = await QueryAPI.GetString(url);
            // serialize into a detail object
            TVDetails td = QueryParser.ParseTVDetails(jsonResult);

            return td;
        }
    }
}