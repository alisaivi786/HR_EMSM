using HR.EMS.Application.Configurations;
using HR.EMS.Application.Contracts.UnitOfWork;
using HR.EMS.Application.JWT;
using HR.EMS.Common.DTOs.AuthDTO;
using HR.EMS.Common.DTOs.LeaveDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Logging;
using HR.EMS.Common.Response;

namespace EMS.Controllers
{
    [Authorize(Policy = "CombinedPolicy")]
    [Route("api/leave")] // Updated route prefix
    [ApiController]
    public class LeaveRequestController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationSettings _applicationSettings;
        private string userId = "";

        public LeaveRequestController(IUnitOfWork unitOfWork, ApplicationSettings applicationSettings)
        {
            _unitOfWork = unitOfWork;
            _applicationSettings = applicationSettings;
           
        }

        [HttpGet("leave-details")] // Updated route name to be more consistent
        public async Task<IActionResult> GetLeaveDetails()
        {
           
            //// Simulate an inner exception
            //var exception = new Exception("Main exception message");
            //// Simulate an inner exception
            //var innerException = new InvalidOperationException("Inner exception message", exception);
            //// Create a custom exception with the inner exception
            //throw new Exception("Custom exception message", innerException);

            var response = await _unitOfWork.LeaveRequestRepository.GetAllAsync();

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpPost("apply-leave")] // Updated route name to be more consistent
        public async Task<IActionResult> ApplyLeave(LeaveRequestDTO requestDTO)
        {
            if (HttpContext.Request.Cookies.TryGetValue("auth_token", out string authToken))
            {
                JWTTokenAuthincation.ValidateJwtToken(authToken, _applicationSettings, out ClaimsIdentity identity);
                Claim nameIdentifierClaim = identity.FindFirst(ClaimTypes.NameIdentifier);
                userId = nameIdentifierClaim.Value;
            }

            requestDTO.RequestingEmployeeId = Convert.ToInt64(userId);

            var response = await _unitOfWork.LeaveRequestRepository.AddAsync(requestDTO);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
            
        }

        [HttpPut("delete-leave")] // Updated route name to be more consistent
        public async Task<IActionResult> DeleteLeave(LeaveDeleteDTO requestDTO)
        {
            // Access the claims and identity data
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userName = User.FindFirst(ClaimTypes.Name)?.Value;
            var userRole = User.FindFirst(ClaimTypes.Role)?.Value;

            requestDTO.RequestingEmployeeId = Convert.ToInt32(userId);

            var response = await _unitOfWork.LeaveRequestRepository.DeleteAsync(requestDTO);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpGet("dashboard")] // Updated route name to be more consistent
        public async Task<IActionResult> Dashboard()
        {
            // Access the claims and identity data
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            int id = Convert.ToInt32(userId);
            var response = await _unitOfWork.LeaveRequestRepository.DashBoardAsync(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }
    }
}
