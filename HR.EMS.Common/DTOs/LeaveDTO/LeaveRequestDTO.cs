
namespace HR.EMS.Common.DTOs.LeaveDTO;

public class LeaveRequestDTO
{
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public long LeaveTypeId { get; set; }

    //public DateTime DateRequested { get; set; } = DateTime.Now;

    public string? RequestComments { get; set; }

    //public bool? Approved { get; set; } = false;

    //public bool Cancelled { get; set; } = false;

    public long RequestingEmployeeId { get; set; }
}
