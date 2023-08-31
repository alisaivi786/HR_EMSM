using HR.EMS.Application.Contracts.UnitOfWork;
using HR.EMS.Common.DTOs.AuthDTO;
using Microsoft.AspNetCore.Mvc;

namespace HR.EMS.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public AuthController(IUnitOfWork unitOfWork)
    {
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

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequestDTO registerRequest)
    {
        var registrationResponse = await _unitOfWork.AuthRepository.RegisterAsync(registerRequest);

        if (registrationResponse.Success)
        {
            return Ok(registrationResponse);
        }

        return BadRequest(registrationResponse);
    }
}
