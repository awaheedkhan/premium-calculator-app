using PremiumCalculator.Api.Common;

namespace PremiumCalculator.Api.Data.Entities
{
    public class Occupation : BaseEntity
    {
        public string Label { get; set; }
        public virtual Rating Rating { get; set; }
    }
}
