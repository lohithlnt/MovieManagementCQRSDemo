using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieManagementLibrary.Commands;
using MovieManagementLibrary.Models;
using MovieManagementLibrary.Queries;

namespace MovieManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator mediator;
        public MoviesController(IMediator Mediator)
        {
            this.mediator = Mediator;
        }
        //GET : api/<MoviesController>
        [HttpGet]
        public async Task<List<MovieModel>> Get()
        {
            return await mediator.Send(new GetMovieListQuery());
        }
        //GET by id : api/<MoviesController>
        [HttpGet("{id}")]
        public async Task<MovieModel> Get(int id)
        {
            return await mediator.Send(new GetMovieByIdQuery(id));
        }
        //POST : api/<MoviesController>
        [HttpPost]
        public async Task<MovieModel> Post(MovieModel movieModel)
        {
            return await mediator.Send(new AddMovieCommand(movieModel));
        }
    }
}
