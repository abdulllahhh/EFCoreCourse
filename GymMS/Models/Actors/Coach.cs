using GymMS.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace GymMS.Models.Actors
{
    public class Coach
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public PasswordHasher<string> MyProperty { get; set; }
        public PhoneAttribute PhoneNumber { get; set; }
        public string bio { get; set; }
        public CoachSpecialization Specialization { get; set; }
        public byte[] ProfilePicture { get; set; }
    }
}
