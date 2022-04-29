using MediatR;
using MovieManagementLibrary.Models;

namespace MovieManagementLibrary.Queries
{
    public record GetMovieListQuery() : IRequest<List<MovieModel>>;
}
