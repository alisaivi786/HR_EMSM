using System.ComponentModel.DataAnnotations.Schema;

namespace HR.EMS.Domain;

public class LeaveRequest : BaseEntity
{
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
   
    

    public DateTime DateRequested { get; set; }

    public string? RequestComments { get; set; }

    public bool? Approved { get; set; }

    public bool Cancelled { get; set; }
   
    [ForeignKey("Id")]
    public long EmployeeId { get; set; }
    [ExcludeParameter]
    public virtual Users? Employee { get; set; }

    [ExcludeParameter]
    public virtual LeaveTypes? LeaveType { get; set; }
    [ForeignKey("Id")]
    public long LeaveTypeId { get; set; }
}
