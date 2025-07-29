using Microsoft.AspNetCore.Identity;

namespace MovieAPI.Persistance.Identity
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? ImageURL { get; set; }
    }
}
