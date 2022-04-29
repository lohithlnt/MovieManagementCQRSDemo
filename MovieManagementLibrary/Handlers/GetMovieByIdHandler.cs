using MediatR;
using MovieManagementLibrary.Models;
using MovieManagementLibrary.Queries;

namespace MovieManagementLibrary.Handlers
{
    public class GetMovieByIdHandler:IRequestHandler<GetMovieByIdQuery, MovieModel>
    {

        private readonly IMediator mediator;
        public GetMovieByIdHandler(IMediator Mediator)
        {
            this.mediator = Mediator;

        }

        public async Task<MovieModel> Handle(GetMovieByIdQuery request, CancellationToken cancellationToken)
        {
            var movies = await mediator.Send(new GetMovieListQuery());
            var movie = movies.FirstOrDefault(u => u.Id == request.id);
            return movie;
        }
    }
}
