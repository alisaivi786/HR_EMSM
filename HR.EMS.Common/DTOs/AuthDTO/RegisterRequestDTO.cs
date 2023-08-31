
namespace HR.EMS.Common.DTOs.AuthDTO;

public class RegisterRequestDTO
{
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public long RoleId { get; set; } = 2;
}
