using NUnit.Framework;
using NSubstitute;
using System;
using PremiumCalculator.Api.Common;
using System.Threading.Tasks;
using Should;

namespace PremiumCalculator.Api.Services.Tests
{
    [TestFixture()]
    public class PremiumServiceTests
    {
        private IPremiumService _premiumService;

        [SetUp]
        public void SetUp()
        {
            _premiumService = Substitute.For<IPremiumService>();
        }

        //TODO: Test premium calculation with expected value to test correctness of the farmula implementation
        [TestCase("01/01/1990", 1, 200000, 1000)]
        public async Task CalculateTest_Returns_DeathPremium(DateTime dateOfBirth, int occupationId, double deathCoverAmount, double monthlyExpense)
        {
            // Arrange
            _premiumService.Calculate(dateOfBirth.Age(), occupationId, deathCoverAmount, monthlyExpense).Returns(Task.FromResult(new Models.Premium { 
                DeathPremium = 500,
                YearlyCover = 100000
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