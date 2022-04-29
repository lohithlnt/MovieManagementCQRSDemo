using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
