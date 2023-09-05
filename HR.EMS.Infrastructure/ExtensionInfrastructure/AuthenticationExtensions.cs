using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Infrastructure.ExtensionInfrastructure;

public static class AuthenticationExtensions
{
    public static IServiceCollection AddCustomJwtAuthentication(this IServiceCollection services, string tokenSecret)
    {
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = tokenSecret,
                    ValidAudience = "v1",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSecret))
                };
            });

        return services;
    }

    public static IServiceCollection AddCustomAuthorizationPolicies(this IServiceCollection services)
    {
        services.AddAuthorization(options =>
        {
            options.AddPolicy("AdminPolicy", policy =>
                policy.RequireClaim(ClaimTypes.Role, "admin"));
            options.AddPolicy("EmployeePolicy", policy =>
                policy.RequireClaim("role", "employee"));
            options.AddPolicy("CombinedPolicy", policy =>
            {
                policy.RequireClaim(ClaimTypes.Role, "admin", "employee");
                // Add any additional requirements if needed
            });
        });

        return services;
    }
}
