using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace AuthenticationApi.Model
{
    public class Register
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
