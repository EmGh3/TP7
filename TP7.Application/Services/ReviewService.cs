using TP7.Application.ServiceInterfaces;
using TP7.Domain.Models;
using TP7.Domain.RepositoryInterfaces;

namespace TP7.Application.Services
{
    public class ReviewService : GenericService<Review>, IReviewService
    {
        private readonly IReviewRepository _reviewRep;
        public ReviewService(IReviewRepository repository) : base(repository)
        {
            _reviewRep = repository;
        }
        public IEnumerable<Review> GetReviewsByMovieId(int movieId)
        {
            return _reviewRep.GetReviewsByMovieId(movieId);
        }
        public double GetAverage(int movieId)
        {
            IEnumerable<Review> reviews = _reviewRep.GetReviewsByMovieId(movieId);
            if (!reviews.Any())
            {
                return 0; 
            }
            return reviews.Average(r => r.Note);
        }
    }
}
