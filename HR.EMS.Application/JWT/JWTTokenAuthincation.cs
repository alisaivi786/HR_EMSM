using HR.EMS.Application.Configurations;
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

namespace HR.EMS.Application.JWT;

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
    public static string GenerateJwtToken(Users user,ApplicationSettings applicationSettings)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(applicationSettings.TokenSecret));

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
    public static bool ValidateJwtToken(string token, ApplicationSettings applicationSettings)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(applicationSettings.TokenSecret));

        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false, 
            ValidateAudience = false, 
            ValidateLifetime = true, 
            ValidateIssuerSigningKey = true,
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

    public static bool ValidateJwtToken(string token,ApplicationSettings applicationSettings, out ClaimsIdentity identity)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(applicationSettings.TokenSecret));

        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false, 
            ValidateAudience = false,
            ValidateLifetime = true, 
            ValidateIssuerSigningKey = true,
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