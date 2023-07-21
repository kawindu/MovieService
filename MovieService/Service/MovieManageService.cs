using MovieService.Models;
using MovieService.Repository;

namespace MovieService.Service
{
    public class MovieManageService: IMovieManageService
    {
        private readonly IMovieRepository _movieRepository;


        public MovieManageService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }


        public async Task<Movie> GetMovieAsync(int id)
        {
            return await _movieRepository.GetMovieAsync(id);
        }


        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _movieRepository.GetAllMoviesAsync();
        }

    }
}
