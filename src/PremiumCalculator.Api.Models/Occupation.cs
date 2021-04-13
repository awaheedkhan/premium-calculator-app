using PremiumCalculator.Api.Common;

namespace PremiumCalculator.Api.Models
{
    public class Occupation : BaseModel
    {
        public int Id { get; set; }
        public string Label { get; set; }
    }
}
