using HR.EMS.Application.Contracts.UnitOfWork;
using HR.EMS.Common.DTOs.AuthDTO;
using HR.EMS.Common.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EMS.Controllers
{
    [AllowAnonymous]
    [Route("api/auth")]
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
                //Response.Cookies.Append("auth_token", authResponse.Data.Token, new CookieOptions
                //{
                //    HttpOnly = true,
                //    // Set other cookie options like expiration if needed
                //});
                return Ok(authResponse);
            }
            return Unauthorized(authResponse);
        }
        [HttpGet("get-token")]
        public IActionResult GetToken()
        {
            // Get the value of the "auth_token" cookie
            if (HttpContext.Request.Cookies.TryGetValue("auth_token", out string authToken))
            {
                // authToken contains the value of the "auth_token" cookie
                // You can use it as needed
                var response = new APIResponse<string>() { Data = authToken, Message = "valid token" };
                return Ok(response);
            }
            else
            {
                // The "auth_token" cookie was not found
                return Unauthorized();
            }
            
        }
       
        [HttpGet("token-auhtenticated")]
        public IActionResult TokenAuthenticated()
        {
            // Get the value of the "auth_token" cookie
            if (HttpContext.Request.Cookies.TryGetValue("auth_token", out string authToken))
            {
                // authToken contains the value of the "auth_token" cookie
                // You can use it as needed
                var response = new APIResponse<bool>() { Data = true ,Message = "valid token"};
                return Ok(response);
            }
            else
            {
                // The "auth_token" cookie was not found
                return Unauthorized();
            }
        }
    }
}
