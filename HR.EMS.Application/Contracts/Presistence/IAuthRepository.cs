using HR.EMS.Common.DTOs.AuthDTO;
using HR.EMS.Common.Response;

namespace HR.EMS.Application.Contracts.Presistence;

public interface IAuthRepository
{
    Task<APIResponse<AuthResponseDTO>> AuthenticateAsync(AuthRequestDTO authRequest);
    Task<APIResponse<RegisterResponseDTO>> RegisterAsync(RegisterRequestDTO registerRequest);
}
