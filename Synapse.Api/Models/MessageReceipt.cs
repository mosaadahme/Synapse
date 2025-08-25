namespace Synapse.Api.Models
{
    public class MessageReceipt
    { 
        public int MessageId { get; set; }
        public Message Message { get; set; }

        public Guid UserId { get; set; } // المستخدم اللي استلم/قرأ
        public User User { get; set; }

        public DateTime? ReceivedAt { get; set; }
        public DateTime? ReadAt { get; set; }
    }
}
