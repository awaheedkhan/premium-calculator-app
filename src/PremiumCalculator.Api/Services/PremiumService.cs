using PremiumCalculator.Api.Models;
using System.Threading.Tasks;

namespace PremiumCalculator.Api.Services
{
    public class PremiumService : IPremiumService
    {
        public Task<Premium> Calculate(int age, int occupationId, double deathCoverAmount, double monthlyExpense)
        {
            throw new System.NotImplementedException();
        }
    }
}
