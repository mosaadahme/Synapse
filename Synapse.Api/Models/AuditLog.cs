namespace Synapse.Api.Models
{
    public class AuditLog
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public AuditAction Action { get; set; }
        public string ?Details { get; set; }

        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
    public enum AuditAction
    {
        JoinGroup,
        LeaveGroup,
        SendMessage,
        EditMessage,
        DeleteMessage,
        PromoteToAdmin,
        KickUser,
        BlockUser,
        UnblockUser
    }
}
