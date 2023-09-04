using System.ComponentModel.DataAnnotations.Schema;

namespace HR.EMS.Domain;
public class LeaveAllocations : BaseEntity
{
    [ForeignKey("Id")]
    public long EmployeeId { get; set; }
    public virtual Users? Employee { get; set; }
    [ForeignKey("Id")]
    public long LeaveTypeId { get; set; }
    public virtual LeaveTypes? LeaveType { get; set; }
}
