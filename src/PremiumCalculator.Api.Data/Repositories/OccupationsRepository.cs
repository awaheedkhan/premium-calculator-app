using PremiumCalculator.Api.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Api.Data.Repositories
{
    public class OccupationsRepository : IOccupationsRepository
    {
        public Task<Occupation> Get(int id)
        {
            return Task.Run(() => Database.Occupations.FirstOrDefault(occupation => occupation.Id == id));
        }
    }
}
