namespace Synapse.Api.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string ?Title { get; set; }
        public string ?Body {  get; set; }

        public int? MessageId { get; set; }
        public Message Message { get; set; }

        public Guid? ReceiverId{ get; set; }
        public User Receiver { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; }
        public bool IsRead { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
