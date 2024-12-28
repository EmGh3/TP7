
using TP7.Domain.Models;

namespace TP7.Application.ServiceInterfaces
{
    public interface IReviewService : IGenericService<Review>
    {
        public IEnumerable<Review> GetReviewsByMovieId(int movieId);
        public double GetAverage(int movieId);
    }
}
