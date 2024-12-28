using Microsoft.EntityFrameworkCore;

namespace TP7.Domain.Models
{
    public class ClientMovie
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client? Client { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}
