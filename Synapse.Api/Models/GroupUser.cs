namespace Synapse.Api.Models
{
    public class GroupUser
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }

        public UserRoleInGroup UserRoleInGroup { get; set; }
        public bool IsMuted { get; set; }
        public DateTime JoinedAt { get; set; }
    }

    public enum UserRoleInGroup 
    {
        Pending,
        Member,
        Admin,
        ReadOnly,
        Moderator
    }
}
