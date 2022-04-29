using MovieManagementLibrary.Models;

namespace MovieManagementLibrary.Data
{
    public interface IDataRepository
    {
        List<MovieModel> GetMovies();
        MovieModel AddMovie(MovieModel movie);
    }
}
