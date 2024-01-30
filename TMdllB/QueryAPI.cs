namespace TMdllB
{
    public static class QueryAPI
    {
        // **** Properties

        // The static http client to be used in the duration of the program
        private static HttpClient _httpClient = new HttpClient();

        // **** Methods

        /*
         * Async method that returns the HttpResponseMessage from a get request taking in one string paramter for the url
         */
        public static async Task<HttpResponseMessage> GetResponse(string url)
        {
            HttpResponseMessage result = await _httpClient.GetAsync(url);
            return result;
        }
         
        /*
         * An overload for the async GetString method that takes in a one string parameter for the url and returns the content for the response.
         */
        public static async Task<string> GetString(string url)
        {
            HttpResponseMessage res = await GetResponse(url);
            // Check for no errors in the message
            res.EnsureSuccessStatusCode();

            string text = await res.Content.ReadAsStringAsync();
            return text;
        }

        /*
         * An overload for the async GetString method that takes in one HttpResponseMessage parameter and returns the content for the resposne.
         * Assumes that the HttpResponseMessage has already been checked for error codes and successful status codes.
         */
        public static async Task<string> GetString(HttpResponseMessage res)
        {
            string text = await res.Content.ReadAsStringAsync();
            return text;
        }

        
    }
}
