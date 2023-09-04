
namespace HR.EMS.Common.DTOs.LeaveDTO;

public class LeaveRequestDTO
{
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public long LeaveTypeId { get; set; }

    public string? RequestComments { get; set; }

    public long RequestingEmployeeId { get; set; }
}
