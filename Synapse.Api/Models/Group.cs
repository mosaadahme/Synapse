﻿namespace Synapse.Api.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ProfileImageUrl { get; set; }  
        public string? Description { get; set; }  
        public bool IsPublic { get; set; }
        public bool IsAdminOnlyPosting { get; set; } = false;
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
    }
}
