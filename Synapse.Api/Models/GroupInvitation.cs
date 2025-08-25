namespace Synapse.Api.Models
{
    public class GroupInvitation
    {
        public int Id { get; set; }

        public int ?GroupId { get; set; }
        public Group Group { get; set; }

        public Guid? InviterId { get; set; }
        public User Inviter { get; set; }

        public Guid? InvitedUserId { get; set; }
        public User InvitedUser { get; set; }


        public bool IsPublic { get; set; } = false;
        public string Token { get; set; } = Guid.NewGuid ( ).ToString ( );
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ExpiresAt { get; set; } = null;
        public bool IsAccepted { get; set; } = false;
    }
}
