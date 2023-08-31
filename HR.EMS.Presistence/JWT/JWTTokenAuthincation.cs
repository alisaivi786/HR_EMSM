using System.Security.Cryptography;

namespace HR.EMS.Presistence.JWT;

/*
 * Author: ALI RAZA MUSHTAQ
 * Email: alisaivi786@gmail.com
 */

public static class JWTTokenAuthincation
{
    /// <summary>
    /// Generates a JWT token for the provided user.
    /// </summary>
    /// <param name="user">The user for whom to generate the token.</param>
    /// <returns>The generated JWT token.</returns>
    public static string GenerateJwtToken(Users user)
    {
        // Generate a key with appropriate size
        var keyBytes = new Rfc2898DeriveBytes("EMS_HR_TEST", saltSize: 16, iterations: 10000).GetBytes(256 / 8);
        var symmetricSecurityKey = new SymmetricSecurityKey(keyBytes);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.UserName),
            // Add additional claims here
            new Claim(ClaimTypes.Role, $"{user.RoleId}"),
            //new Claim(ClaimTypes.Role, $"{user.Role?.Name}"),
        }),
            Expires = DateTime.UtcNow.AddDays(1), // Token expiration time
            SigningCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature)
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}

