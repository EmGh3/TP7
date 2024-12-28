using Microsoft.EntityFrameworkCore;
using TP7.Domain.Models;
using TP7.Domain.RepositoryInterfaces;

namespace TP7.Infrastructure.Repositories
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(ApplicationDbContext context) : base(context)
        {
        }
        public IEnumerable<Movie> GetAllMoviesOrdered()
        {
            return _dbSet
                .OrderBy(m => m.Name)
                .Include(m => m.Genre)
                .ToList();
        }
        public IEnumerable<Movie> GetMoviesByGenreId(int genreId)
        {
            return _dbSet
                .Include(m => m.Genre)
                .Where(m => m.GenreId == genreId)
                .ToList();
        }


    }
}
