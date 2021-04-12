using PremiumCalculator.Api.Data.Entities;
using System.Threading.Tasks;

namespace PremiumCalculator.Api.Data.Repositories
{
    public interface IOccupationsRepository
    {
        Task<Occupation> Get(int id);
    }
}
