namespace TP7.Domain.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Note { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
        public int ClientId { get; set; }
        public Client? Client { get; set; }
    }
}
