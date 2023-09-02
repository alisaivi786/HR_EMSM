namespace HR.EMS.Domain.Abstract;

public abstract class BaseEntity
{
    public long Id { get; set; }
    public Guid? RowId { get; set; } = Guid.NewGuid();
    public DateTime? DateCreated { get; set; } = DateTime.Now;
    public long? CreatedBy { get; set; } 
    public DateTime? DateModified { get; set; }
    public long? ModifiedBy { get; set; }
    public DateTime? DateDeleted { get; set; }
    public long? DeletedBy { get; set; }
    public bool? IsActive { get; set; } = true;
    public bool? IsDeleted { get; set; } = false;

}
