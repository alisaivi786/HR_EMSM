using System.Data;

namespace HR.EMS.Domain;

public class Users : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public bool IsEmailConfirmed { get; set; } = false;
    public long RoleId { get; set; } = 2; // Foreign key to Role=> 1: Admin, 2: Employee
    public Roles? Role { get; set; } // Navigation property
}
