using MovieService.Models;

namespace MovieService.Service
{
    public interface IMovieManageService
    {
        Task<Movie> GetMovieAsync(int id);
        Task<IEnumerable<Movie>> GetAllMoviesAsync();

    }
}
