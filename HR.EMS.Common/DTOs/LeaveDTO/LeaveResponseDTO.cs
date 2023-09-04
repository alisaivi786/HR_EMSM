
namespace HR.EMS.Common.DTOs.LeaveDTO;

public class LeaveResponseDTO
{
    public long LeaveId { get; set; }
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
    
    public long? LeaveTypeId { get; set; }

    public DateTime DateRequested { get; set; }

    public string? RequestComments { get; set; }

    public bool? Approved { get; set; }

    public bool Cancelled { get; set; }

    public string? Employee { get; set; }
}
