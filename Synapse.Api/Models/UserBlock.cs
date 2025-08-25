namespace Synapse.Api.Models
{
    public class UserBlock
    {
        public int Id { get; set; }

        public Guid BlockerId { get; set; }
        public User Blocker{ get; set; }

        public Guid BlockedId { get; set; }
        public User Blocked { get; set; }

        public int ?GroupId { get; set; }
        public Group Group { get; set; }

        public DateTime BlockedAt { get; set; }= DateTime.Now;
    }
}
