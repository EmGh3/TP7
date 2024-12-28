using Microsoft.EntityFrameworkCore;
using TP7.Domain.Models;
using TP7.Domain.RepositoryInterfaces;

namespace TP7.Infrastructure.Repositories
{
    public class ClientMovieRepository : GenericRepository<ClientMovie>, IClientMovieRepository
    {
        public ClientMovieRepository(ApplicationDbContext context) : base(context)
        {
        }
        public IEnumerable<Movie> GetMoviesByClientId(int clientId)
        {
            return _dbSet
                .Include(m => m.Movie)
                .Where(m => m.ClientId == clientId)
                .Select(m => m.Movie)
                .ToList();
        }
    }
}
