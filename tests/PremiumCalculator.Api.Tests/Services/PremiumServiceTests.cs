using NUnit.Framework;
using NSubstitute;
using System;
using PremiumCalculator.Api.Common;
using System.Threading.Tasks;
using Should;
using PremiumCalculator.Api.Data.Repositories;

namespace PremiumCalculator.Api.Services.Tests
{
    [TestFixture()]
    public class PremiumServiceTests
    {
        private IPremiumService _premiumService;
        private IOccupationsRepository _occupationsRepository;

        [SetUp]
        public void SetUp()
        {
            _occupationsRepository = Substitute.For<IOccupationsRepository>();
            _premiumService = new PremiumService(_occupationsRepository);
        }

        //TODO: Test premium calculation with expected value to test correctness of the farmula implementation
        [TestCase("01/01/1990", 1, 200000, 1000)]
        public async Task CalculateTest_Returns_DeathPremium(DateTime dateOfBirth, int occupationId, double deathCoverAmount, double monthlyExpense)
        {
            // Arrange
            _occupationsRepository.Get(occupationId).Returns(Task.FromResult(new Data.Entities.Occupation { 
                Id = 1,
                Label = "",
                Rating = new Data.Entities.Rating { 
                    Id = 1,
                    Factor = 1.1
                }
            }));

            // Act
            var result = await _premiumService.Calculate(dateOfBirth.Age(), occupationId, deathCoverAmount, monthlyExpense);


            // Assert
            result.ShouldNotBeNull();
            result.DeathPremium.ShouldBeGreaterThan(0);
            result.YearlyCover.ShouldBeGreaterThan(0);
        }
    }
}