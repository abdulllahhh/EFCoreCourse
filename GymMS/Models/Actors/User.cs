using System.ComponentModel.DataAnnotations;

namespace GymMS.Models.Actors
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public PhoneAttribute PhonenNumber { get; set; }
        public byte[] ProfilePicture { get; set; }
        public int ProgramId { get; set; }
        public int SubscriptionId { get; set; }
    }
}
