using MediatR;
using MovieManagementLibrary.Models;

namespace MovieManagementLibrary.Commands
{
    public record AddMovieCommand(MovieModel model) : IRequest<MovieModel>;
}
