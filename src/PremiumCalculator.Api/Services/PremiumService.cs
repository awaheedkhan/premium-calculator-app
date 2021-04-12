using PremiumCalculator.Api.Data.Repositories;
using PremiumCalculator.Api.Models;
using System;
using System.Threading.Tasks;

namespace PremiumCalculator.Api.Services
{
    public class PremiumService : IPremiumService
    {
        private IOccupationsRepository _occupationRepository;
        const double MONTHLY_PREMIUM_DENOMINATOR = 1000 * 12;

        public PremiumService(IOccupationsRepository occupationsRepository)
        {
            _occupationRepository = occupationsRepository;
        }

        public async Task<Premium> Calculate(int age, int occupationId, double deathCoverAmount, double monthlyExpense)
        {
            var occupation = await _occupationRepository.Get(occupationId);

            if (occupation == null)
                throw new Exception("Occupation not found."); // TODO: Throw specific business exception to be logged properly

            return new Premium {
                // TODO: Get this value from a monthly preminum strategy
                DeathPremium = (deathCoverAmount * occupation.Rating.Factor * age) / MONTHLY_PREMIUM_DENOMINATOR,
                // TODO: Get this value from yearly cover strategy
                YearlyCover = monthlyExpense * occupation.Rating.Factor * age 
            };
        }
    }
}
