using GymMS.Models.Enums;

namespace GymMS.Models.Utilities
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public int CoachId { get; set; }
        public ClassType Type { get; set; }
        public AgeGroup MyProperty { get; set; }
        public SubscriptionPlan subscriptionPlan { get; set; }
        public double Price { get; set; }

    }
}
