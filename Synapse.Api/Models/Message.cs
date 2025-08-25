namespace Synapse.Api.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public MessageType Type { get; set; }
        public DateTime SendAt { get; set; } = DateTime.Now;


        public Guid UserId { get; set; }
        public User User { get; set; }

        public int? GroupId { get; set; }
        public Group Group { get; set; }

        public int?ParentMessageId { get; set; }
        public Message ParentMessage { get; set; }
        public virtual ICollection<Message> Replies { get; set; }

        public DateTime? ExpiresAt { get; set; }

        public DateTime? EditAt { get; set; }

        public DateTime? DeleteAt { get; set; }
        public bool IsDeleted { get; set; } = false;

        public virtual ICollection<MessageReceipt> Receipts { get; set; }
        public virtual ICollection<MessageReaction> Reactions { get; set; }

    }
    public enum MessageType 
    {
        Text,
        Image,
        Video,
        Audio,
        File

    }
}
