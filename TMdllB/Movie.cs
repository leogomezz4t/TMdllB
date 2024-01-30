namespace TMdllB
{
    public class Movie
    {
        // **** Private properties

        /*
         * A reference to the TMDbClient that created this instance
         */
        private TMDbClient _parentClient { get; set; }

        /*
         * A reference to the serialized result object returned by the TMDB API
         */
        private MovieResult _searchResult { get; set; }

    // **** Constructor
    public Movie(MovieResult result, TMDbClient parentClient)
        {
            _searchResult = result;
            _parentClient = parentClient;

            // **** initializing public properties
            Id = _searchResult.Id;
            IsAdult = _searchResult.IsAdult;
            GenreIds = _searchResult.GenreIds;
            BackdropPath = _searchResult.BackdropPath;
            OriginalLanguage = _searchResult.OriginalLanguage;
            OriginalTitle = _searchResult.OriginalTitle;
            Overview = _searchResult.Overview;
            Popularity = _searchResult.Popularity;
            PosterPath = _searchResult.PosterPath;
            ReleaseDate = _searchResult.ReleaseDate;
            Title = _searchResult.Title;
            HasVideo = _searchResult.Video;
            VoteAverage = _searchResult.VoteAverage;
            VoteCount = _searchResult.VoteCount;
        }

        // **** Public Properties
        public int Id { get; }

        public bool IsAdult { get; }

        public int[] GenreIds { get; }

        public string BackdropPath { get; }

        public string OriginalLanguage { get; }
        
        public string OriginalTitle { get; }

        public string Overview { get; }

        public float Popularity { get; }

        public string PosterPath { get; }

        public DateOnly ReleaseDate { get; }

        public string Title { get; }

        public bool HasVideo { get; }
        
        public float VoteAverage { get; }

        public int VoteCount { get; }
    }
}
