using Microsoft.AspNetCore.Identity;

namespace Synapse.Api.Models
{
    public class User:IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string ProfileImageUrl { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get 
            {
                var today= DateTime.UtcNow;
                var age= today.Year-DateOfBirth.Year;
                if ( DateOfBirth.Date > today.AddYears ( -age ) ) age--;
                return Age;
            }
        }
        public bool IsOnline { get; set; }=false;
        public DateTime? LastSeen { get; set; }

    }
}
