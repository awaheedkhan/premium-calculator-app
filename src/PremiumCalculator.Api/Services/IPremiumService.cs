using PremiumCalculator.Api.Common;
using PremiumCalculator.Api.Models;
using System.Threading.Tasks;

namespace PremiumCalculator.Api.Services
{
    public interface IPremiumService : IService<Premium>
    {
        Task<Premium> Calculate(int age, int occupationId, double deathCoverAmount, double monthlyExpense);
    }
}
