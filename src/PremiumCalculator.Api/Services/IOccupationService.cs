using PremiumCalculator.Api.Common;
using PremiumCalculator.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PremiumCalculator.Api.Services
{
    public interface IOccupationService : IService<Occupation>
    {
        Task<List<Occupation>> Get();
    }
}
