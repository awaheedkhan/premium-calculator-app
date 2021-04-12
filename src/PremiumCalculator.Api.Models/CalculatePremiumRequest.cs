using System;
using System.Collections.Generic;
using System.Text;

namespace PremiumCalculator.Api.Models
{
    public class CalculatePremiumRequest
    {
        public DateTime DateOfBirth { get; set; }
        public int OccupationId { get; set; }
        public double DeathCover { get; set; }
        public double MonthlyExpense { get; set; }
    }
}
