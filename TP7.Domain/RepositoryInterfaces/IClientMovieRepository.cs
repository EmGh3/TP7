using TP7.Domain.Models;

namespace TP7.Domain.RepositoryInterfaces
{
    public interface IClientMovieRepository : IRepository<ClientMovie>
    {
        public IEnumerable<Movie> GetMoviesByClientId(int clientId);
    }
}
