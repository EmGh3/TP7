using Microsoft.EntityFrameworkCore;
using TP7.Domain.Models;
using TP7.Domain.RepositoryInterfaces;

namespace TP7.Infrastructure.Repositories
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(ApplicationDbContext context) : base(context)
        {
        }
        public IEnumerable<Review> GetReviewsByMovieId(int movieId)
        {
            return _dbSet
                .Where(review => review.MovieId == movieId)
                .Include(review => review.Client)
                .ToList();
        }
    }
}
