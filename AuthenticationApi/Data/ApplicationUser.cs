using Microsoft.AspNetCore.Identity;

namespace AuthenticationApi.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
