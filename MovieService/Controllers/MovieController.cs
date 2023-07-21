using Microsoft.AspNetCore.Mvc;
using MovieService.Models;
using MovieService.Service;

namespace MovieService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IMovieManageService _movieService;

        public MovieController(ILogger<MovieController> logger, IMovieManageService movieService)
        {
            _logger = logger;
            _movieService = movieService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            try
            {
                var movies = _movieService.GetAllMoviesAsync();
                return Ok(movies);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching movies.");
                return StatusCode(500, "An error occurred while fetching movies.");
            }
        }

    }
}