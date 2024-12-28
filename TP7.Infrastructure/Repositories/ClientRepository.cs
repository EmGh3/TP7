using TP7.Domain.Models;
using TP7.Domain.RepositoryInterfaces;

namespace TP7.Infrastructure.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}

