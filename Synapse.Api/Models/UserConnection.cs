namespace Synapse.Api.Models
{
    public class UserConnection
    { 
        public Guid UserId { get; set; }
        public User User { get; set; }

        public string ConnectionId { get; set; }
        public DateTime ConnectedAt { get; set; }

    }
}
