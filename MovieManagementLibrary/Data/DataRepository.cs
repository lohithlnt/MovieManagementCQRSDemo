using MovieManagementLibrary.Models;

namespace MovieManagementLibrary.Data
{
    public class DataRepository : IDataRepository
    {
        private static List<MovieModel> movies = new()
        {
            new MovieModel { Id = 1, Name = "KGF", Cost = 100000000 },
            new MovieModel { Id = 2, Name = "Pushpa", Cost = 10000000 }
        };
        public MovieModel AddMovie(MovieModel movie)
        {
            movies.Add(movie);
            return movie;
        }

        public List<MovieModel> GetMovies()
        {
            return movies;
        }
    }
}
