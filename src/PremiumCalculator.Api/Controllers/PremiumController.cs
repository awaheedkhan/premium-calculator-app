using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PremiumCalculator.Api.Common;
using PremiumCalculator.Api.Models;
using PremiumCalculator.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Api.Controllers
{
    [ApiController]
    [Route(ApiRoute)]
    // TODO: Inherit from BaseController if an infrastructure is developed to provide common attributes or functionality with controllers
    public class PremiumController : ControllerBase 
    {
        private const string ApiRoute = "api/premium";
        private readonly ILogger<PremiumController> _logger;
        private readonly IPremiumService _premiumService;

        public PremiumController(ILogger<PremiumController> logger, IPremiumService premiumService)
        {
            _logger = logger;
            _premiumService = premiumService;
        }

        [HttpGet("monthly")]
        public async Task<IActionResult> Get(MonthlyPremiumRequest monthlyPremiumRequest)
        {
            var result = await _premiumService.Calculate(monthlyPremiumRequest.DateOfBirth.Age()
                , monthlyPremiumRequest.OccupationId
                , monthlyPremiumRequest.DeathCover
                , monthlyPremiumRequest.MonthlyExpense);
            
            return Ok(result);
        }
    }
}
