namespace TMdllB.Movie
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
            RelativeBackdropPath = _searchResult.BackdropPath;
            OriginalLanguage = _searchResult.OriginalLanguage;
            OriginalTitle = _searchResult.OriginalTitle;
            Overview = _searchResult.Overview;
            Popularity = _searchResult.Popularity;
            RelativePosterPath = _searchResult.PosterPath;
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

        public string RelativeBackdropPath { get; }

        public string BackdropPath
        {
            get
            {
                return $"{TMDbClient.IMAGE_BASE_URL}{TMDbClient.IMAGE_ORIGINAL_SIZE_ENDPOINT}{RelativeBackdropPath}";
            }
        }

        public string OriginalLanguage { get; }

        public string OriginalTitle { get; }

        public string Overview { get; }

        public float Popularity { get; }

        public string RelativePosterPath { get; }

        public string PosterPath
        {
            get
            {
                return $"{TMDbClient.IMAGE_BASE_URL}{TMDbClient.IMAGE_ORIGINAL_SIZE_ENDPOINT}{RelativePosterPath}";
            }
        }

        public DateOnly ReleaseDate { get; }

        public string Title { get; }

        public bool HasVideo { get; }

        public float VoteAverage { get; }

        public int VoteCount { get; }
    }
}
