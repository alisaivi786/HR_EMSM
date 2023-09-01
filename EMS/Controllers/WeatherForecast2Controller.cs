using HR.EMS.Application.Contracts.UnitOfWork;
using HR.EMS.Common.DTOs.AuthDTO;
using HR.EMS.Presistence.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecast2Controller : ControllerBase
    {
        
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        private readonly IUnitOfWork _unitOfWork;

        private readonly ILogger<WeatherForecast2Controller> _logger;

        public WeatherForecast2Controller(ILogger<WeatherForecast2Controller> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("abc")]
        public IEnumerable<WeatherForecast> GetABC()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost("login2")]
        public async Task<IActionResult> Login(AuthRequestDTO authRequest)
        {
            var authResponse = await _unitOfWork.AuthRepository.AuthenticateAsync(authRequest);

            if (authResponse.Success)
            {
                return Ok(authResponse);
            }

            return Unauthorized(authResponse);
        }

    }
}