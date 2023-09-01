
using HR.EMS.Common.DTOs.AuthDTO;
using HR.EMS.Common.DTOs.LeaveDTO;
using HR.EMS.Common.Response;

namespace HR.EMS.Application.Contracts.Presistence;

public interface ILeaveRequestRepository
{
    Task<APIResponse<LeaveResponseDTO>> AddAsync(LeaveRequestDTO leaveRequest);
    Task<APIResponse<LeaveDeleteDTO>> DeleteAsync(LeaveDeleteDTO deleteDTO);
    Task<APIResponse<List<LeaveResponseDTO>>> GetAllAsync();
    Task<APIResponse<DashboardDTO>> DashBoardAsync(int Id);
}
