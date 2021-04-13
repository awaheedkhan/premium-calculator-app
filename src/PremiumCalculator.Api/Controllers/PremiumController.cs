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
        private readonly IOccupationService _occupationService;

        public PremiumController(ILogger<PremiumController> logger
            , IPremiumService premiumService
            , IOccupationService occupationService)
        {
            _logger = logger;
            _premiumService = premiumService;
            _occupationService = occupationService;
        }

        [HttpGet("monthly")]
        public async Task<IActionResult> Get([FromQuery]DateTime dateOfBirth, [FromQuery] int occupationId, [FromQuery] double deathCover, [FromQuery] double monthlyExpense)
        {
            var result = await _premiumService.Calculate(dateOfBirth.Age()
                , occupationId
                , deathCover
                , monthlyExpense);
            
            return Ok(result);
        }

        [HttpGet("occupations")]
        // TODO: This endpont should be offered with a separate controller
        public async Task<IActionResult> Occupations()
        {
            var result = await _occupationService.Get();
            return Ok(result);
        }
    }
}
