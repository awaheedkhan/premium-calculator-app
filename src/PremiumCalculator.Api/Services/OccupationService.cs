using PremiumCalculator.Api.Data.Repositories;
using PremiumCalculator.Api.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PremiumCalculator.Api.Services
{
    public class OccupationService : IOccupationService
    {
        private IOccupationsRepository _occupationRepository;

        public OccupationService(IOccupationsRepository occupationsRepository)
        {
            _occupationRepository = occupationsRepository;
        }

        public async Task<List<Occupation>> Get()
        {
            var occupations = await _occupationRepository.Get();

            return occupations?.ConvertAll(occupation => new Occupation { 
                Id = occupation.Id,
                Label = occupation.Label
            });
        }
    }
}
