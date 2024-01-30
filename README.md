# TMdllB
#### A C# .NET wrapper for TMDB (The Movie Database) v3 API

## Documentation
Keep in mind all functions are async and awaitable

## Examples
A simple example of how to search for movies
```csharp
TMDbClient client = new TMDbClient(API_KEY);
List<Movie> movies = await client.SearchMovies("Percy Jackson and the Olympians");
Console.WriteLine($"Name: {movies[0].Title}");
```