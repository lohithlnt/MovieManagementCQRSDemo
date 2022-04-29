using MediatR;
using MovieManagementLibrary.Models;

namespace MovieManagementLibrary.Queries
{
    public record GetMovieByIdQuery(int id): IRequest<MovieModel>;
}
