using TP7.Domain.Models;

namespace TP7.Application.ServiceInterfaces
{
    public interface IClientMovieService: IGenericService<ClientMovie>
    {
        public IEnumerable<Movie> GetMoviesByClientId(int clientId);
    }
}
