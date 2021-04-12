using PremiumCalculator.Api.Common;

namespace PremiumCalculator.Api.Models
{
    public class Premium : BaseModel
    {
        public double DeathPremium { get; set; }
        public double YearlyCover { get; set; }
    }
}
