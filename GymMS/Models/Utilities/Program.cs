using GymMS.Models.Enums;

namespace GymMS.Models.Utilities
{
    public class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CoachSpecialization Type{ get; set; }
        public Duration duration { get; set; }
        public int UserId { get; set; }
        public int CoachId { get; set; }
        public double Price { get; set; }
        public Boolean isActive { get; set; }

    }
}
