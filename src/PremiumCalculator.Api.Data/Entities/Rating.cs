using PremiumCalculator.Api.Common;
using System.Collections.Generic;

namespace PremiumCalculator.Api.Data.Entities
{
    public class Rating : BaseEntity
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public float Factor { get; set; }
        public virtual List<Occupation> Occupations { get; set; }
    }
}
