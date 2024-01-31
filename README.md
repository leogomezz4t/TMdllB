# TMdllB
#### A C# .NET wrapper for TMDB (The Movie Database) v3 API

## Setup
In order to use the TMDB API you need to get an API key. Follow the instructions [here](https://developer.themoviedb.org/docs/getting-started) to receive a key

## Documentation
Keep in mind all functions are async and awaitable

## Examples
A simple example of how to search for movies
```csharp
TMDbClient client = new TMDbClient(API_KEY);
List<Movie> movies = await client.SearchMovies("Percy Jackson and the Olympians");
Console.WriteLine($"Name: {movies[0].Title}");
```