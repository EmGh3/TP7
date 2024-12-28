using TP7.Domain.Models;

namespace TP7.Domain.RepositoryInterfaces
{
    public interface IReviewRepository: IRepository<Review>
    {
        public IEnumerable<Review> GetReviewsByMovieId(int  movieId);
    }
}
