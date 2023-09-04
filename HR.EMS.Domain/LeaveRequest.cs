namespace HR.EMS.Domain;

public class LeaveRequest : BaseEntity
{
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
    [ExcludeParameter]
    public LeaveTypes? LeaveType { get; set; }

    public long LeaveTypeId { get; set; }
    

    public DateTime DateRequested { get; set; }

    public string? RequestComments { get; set; }

    public bool? Approved { get; set; }

    public bool Cancelled { get; set; }
    [ExcludeParameter]
    public Users? Employee { get; set; }
    public long EmployeeId { get; set; }
}
