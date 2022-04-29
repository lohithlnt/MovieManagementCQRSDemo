using MediatR;
using MovieManagementLibrary.Commands;
using MovieManagementLibrary.Data;
using MovieManagementLibrary.Models;

namespace MovieManagementLibrary.Handlers
{
    public class AddMovieHandler : IRequestHandler<AddMovieCommand, MovieModel>
    {
        private readonly IDataRepository _dataRepository;
        public AddMovieHandler(IDataRepository dataRepository)
        {
            this._dataRepository = dataRepository;
        }
        public Task<MovieModel> Handle(AddMovieCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.AddMovie(request.model));
        }
    }
}
