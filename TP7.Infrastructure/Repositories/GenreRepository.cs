using TP7.Domain.Models;
using TP7.Domain.RepositoryInterfaces;

namespace TP7.Infrastructure.Repositories
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
