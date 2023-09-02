using HR.EMS.Domain;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Infrastructure.JWT;

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
    public static string GenerateJwtToken(Users user, string keyId)
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

    public static string GenerateJwtToken3(Users user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your-secret-key-with-at-least-128-bits"));

        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.UserName),
            // Add additional claims here
            new Claim(ClaimTypes.Role, $"{user.RoleId}"),
            // Add additional claims here
        };

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddMinutes(50), // Token expiration time
            SigningCredentials = credentials
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var jwtToken = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(jwtToken);
    }
    public static bool ValidateJwtToken(string token)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        // var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("EMS_HR_TEST"));
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your-secret-key-with-at-least-128-bits"));


        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false, // Set to true if you want to validate issuer
            ValidateAudience = false, // Set to true if you want to validate audience
            ValidateLifetime = true, // Validate the token's lifetime
            ValidateIssuerSigningKey = true, // Validate the token's signing key
            IssuerSigningKey = securityKey,
        };

        try
        {
            tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);
            return true; // Token is valid
        }
        catch
        {
            return false; // Token validation failed
        }
    }

    public static bool ValidateJwtToken(string token, out ClaimsIdentity identity)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your-secret-key-with-at-least-128-bits"));

        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false, // Set to true if you want to validate issuer
            ValidateAudience = false, // Set to true if you want to validate audience
            ValidateLifetime = true, // Validate the token's lifetime
            ValidateIssuerSigningKey = true, // Validate the token's signing key
            IssuerSigningKey = securityKey,
        };

        try
        {
            tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);

            // Get the claims from the validated token
            var claimsPrincipal = tokenHandler.ValidateToken(token, validationParameters, out validatedToken);
            identity = claimsPrincipal.Identity as ClaimsIdentity;

            return true; // Token is valid
        }
        catch
        {
            identity = null;
            return false; // Token validation failed
        }
    }


}