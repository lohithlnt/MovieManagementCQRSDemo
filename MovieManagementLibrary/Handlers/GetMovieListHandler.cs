using MediatR;
using MovieManagementLibrary.Data;
using MovieManagementLibrary.Models;
using MovieManagementLibrary.Queries;

namespace MovieManagementLibrary.Handlers
{
    public class GetMovieListHandler : IRequestHandler<GetMovieListQuery, List<MovieModel>>
    {
        private readonly IDataRepository _dataRepository;
        public GetMovieListHandler(IDataRepository dataRepository)
        {
            this._dataRepository = dataRepository;
        }
        public Task<List<MovieModel>> Handle(GetMovieListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.GetMovies());
        }
    }
}
