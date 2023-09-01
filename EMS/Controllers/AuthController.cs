using HR.EMS.Application.Contracts.UnitOfWork;
using HR.EMS.Common.DTOs.AuthDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EMS.Controllers
{
    [AllowAnonymous]
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
       
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

       
        [HttpPost("login")]
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
