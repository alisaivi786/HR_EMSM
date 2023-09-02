using HR.EMS.Application.Configurations;
using HR.EMS.Application.Contracts.UnitOfWork;
using HR.EMS.Application.JWT;
using HR.EMS.Common.DTOs.AuthDTO;
using HR.EMS.Common.DTOs.LeaveDTO;
using HR.EMS.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace EMS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LeaveRequestController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationSettings _applicationSettings;

        private readonly ILogger<LeaveRequestController> _logger;

        public LeaveRequestController(ILogger<LeaveRequestController> logger, IUnitOfWork unitOfWork,ApplicationSettings applicationSettings)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _applicationSettings = applicationSettings;
        }

        [HttpGet("LeaveDetails")]
        public async Task<IActionResult> GetLeaveDetails()
        {

            var token = HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Replace("Bearer ", "");
            var tokenValidate = JWTTokenAuthincation.ValidateJwtToken(token, _applicationSettings);

            if (!tokenValidate)
                return Unauthorized();


            if (string.IsNullOrEmpty(token))
            {
                // Token is missing in the request header
                return Unauthorized("Token is missing");
            }
            var response = await _unitOfWork.LeaveRequestRepository.GetAllAsync();

            if (response.Success)
            {
                return Ok(response);
            }

            return Unauthorized(response);
        }

        [HttpPost("ApplyLeave")]
        public async Task<IActionResult> ApplyLeave(LeaveRequestDTO requestDTO)
        {
            var token = HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Replace("Bearer ", "");
            if (JWTTokenAuthincation.ValidateJwtToken(token, _applicationSettings, out var identity))
            {
                // Access the claims and identity data
                var userId = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                var userName = identity.FindFirst(ClaimTypes.Name)?.Value;
                var userRole = identity.FindFirst(ClaimTypes.Role)?.Value;

                requestDTO.RequestingEmployeeId = Convert.ToInt64(userId);
                
                var response = await _unitOfWork.LeaveRequestRepository.AddAsync(requestDTO);

                if (response.Success)
                {
                    return Ok(response);
                }
            }
            return Unauthorized();
        }
        [HttpPut("DeleteLeave")]
        public async Task<IActionResult> DeleteLeave(LeaveDeleteDTO requestDTO)
        {
            var token = HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Replace("Bearer ", "");
            if (JWTTokenAuthincation.ValidateJwtToken(token, _applicationSettings, out var identity))
            {
                // Access the claims and identity data
                var userId = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                var userName = identity.FindFirst(ClaimTypes.Name)?.Value;
                var userRole = identity.FindFirst(ClaimTypes.Role)?.Value;

                requestDTO.RequestingEmployeeId = Convert.ToInt32(userId);

                var response = await _unitOfWork.LeaveRequestRepository.DeleteAsync(requestDTO);

                if (response.Success)
                {
                    return Ok(response);
                }

            }


            return Unauthorized();
        }

        [HttpGet("dashboard")]
        public async Task<IActionResult> Dashboard()
        {

            var token = HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Replace("Bearer ", "");
            if (JWTTokenAuthincation.ValidateJwtToken(token, _applicationSettings,out var identity))
            {
                // Access the claims and identity data
                var userId = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                int id = Convert.ToInt32(userId);
                var response = await _unitOfWork.LeaveRequestRepository.DashBoardAsync(id);

                if (response.Success)
                {
                    return Ok(response);
                }
            }
            return Unauthorized();
        }

    }
}
