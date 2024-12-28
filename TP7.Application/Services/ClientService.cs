using TP7.Application.ServiceInterfaces;
using TP7.Domain.Models;
using TP7.Domain.RepositoryInterfaces;

namespace TP7.Application.Services
{
    public class ClientService : GenericService<Client>, IClientService
    {
        public ClientService(IClientRepository repository) : base(repository)
        {
        }
    }
}
