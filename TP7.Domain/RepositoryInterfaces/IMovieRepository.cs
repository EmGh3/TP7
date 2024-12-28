using TP7.Domain.Models;

namespace TP7.Domain.RepositoryInterfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        public IEnumerable<Movie> GetAllMoviesOrdered();
        public IEnumerable<Movie> GetMoviesByGenreId(int genreId);
    }
}
