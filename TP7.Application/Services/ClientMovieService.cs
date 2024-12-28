using TP7.Application.ServiceInterfaces;
using TP7.Domain.Models;
using TP7.Domain.RepositoryInterfaces;

namespace TP7.Application.Services
{
    public class ClientMovieService : GenericService<ClientMovie>, IClientMovieService
    {
        public ClientMovieService(IClientMovieRepository repository) : base(repository)
        {
        }
        public IEnumerable<Movie> GetMoviesByClientId(int clientId)
        {
           return ((IClientMovieRepository)_repository).GetMoviesByClientId(clientId);
        }
    }
}
