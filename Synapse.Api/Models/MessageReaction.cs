namespace Synapse.Api.Models
{
    public class MessageReaction
    {
        public int Id { get; set; }

        public int MessageId { get; set; }
        public Message Message { get; set; }

        public Guid UserId { get; set; }  
        public User User { get; set; }

        public string Emoji { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
