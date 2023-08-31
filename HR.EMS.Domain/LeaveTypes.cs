namespace HR.EMS.Domain;

public class LeaveTypes : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public int DefaultDays { get; set; } = 0;
}
