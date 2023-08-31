namespace HR.EMS.Domain;
public class LeaveAllocations : BaseEntity
{
    public long NumberOfDays { get; set; }
    public LeaveTypes? LeaveType { get; set; }
    public long LeaveTypeId { get; set; }
    public long Period { get; set; }
    public Users? Employee { get; set; }
    public long EmployeeId { get; set; } 
}
