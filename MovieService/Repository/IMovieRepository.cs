using MovieService.Models;

namespace MovieService.Repository
{
    public interface IMovieRepository
    {
        Task<Movie> GetMovieAsync(int id);
        Task<IEnumerable<Movie>> GetAllMoviesAsync();

    }
}
