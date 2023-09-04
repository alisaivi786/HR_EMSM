using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace HR.EMS.Domain;

public class Users : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public long? GenderId { get; set; }
    public bool IsEmailConfirmed { get; set; } = false;
    [ForeignKey("Id")]
    public long RoleId { get; set; } = 2;

    public virtual Roles? Role { get; set; }
}
