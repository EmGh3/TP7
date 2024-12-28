using TP7.Domain.Models;

namespace TP7.Application.ServiceInterfaces
{
    public interface IMovieService : IGenericService<Movie>
    {
        public IEnumerable<Movie> GetAllMoviesOrdered();
        public IEnumerable<Movie> GetMoviesByGenreId(int genreId);
        
    }
}
