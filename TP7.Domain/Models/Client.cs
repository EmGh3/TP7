using System.ComponentModel.DataAnnotations.Schema;

namespace TP7.Domain.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public IEnumerable<Review>? Reviews { get; set; }
        public IEnumerable<ClientMovie>? Movies { get; set; }
    }
}
