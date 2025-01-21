using Microsoft.AspNetCore.Identity;

namespace GymMS.Models.Actors
{
    public class Admin
    {
        public string userName { get; set; }
        public PasswordHasher<string> password { get; set; }
    }
}
