using TP7.Application.ServiceInterfaces;
using TP7.Domain.Models;
using TP7.Domain.RepositoryInterfaces;

namespace TP7.Application.Services
{
    public class GenreService : GenericService<Genre>, IGenreService
    {
        public GenreService(IGenreRepository repository) : base(repository)
        {
        }
    }
}
