using TP7.Application.ServiceInterfaces;
using TP7.Domain.Models;
using TP7.Domain.RepositoryInterfaces;

namespace TP7.Application.Services
{
    public class MovieService : GenericService<Movie>, IMovieService
    {
        private readonly IMovieRepository _movieRep;
        public MovieService(IMovieRepository repository) : base(repository)
        {
            _movieRep = repository;
        }

        public IEnumerable<Movie> GetAllMoviesOrdered()
        {
            return _movieRep.GetAllMoviesOrdered();
        }

        public IEnumerable<Movie> GetMoviesByGenreId(int genreId)
        {
            return _movieRep.GetMoviesByGenreId(genreId);
        }


    }
}
