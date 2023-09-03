using HR.EMS.Application.Configurations;
using HR.EMS.Application.JWT;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Infrastructure.Middlewares;

public class JwtTokenValidationMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ApplicationSettings _applicationSettings;

    public JwtTokenValidationMiddleware(RequestDelegate next,ApplicationSettings applicationSettings)
    {
        _next = next;
        _applicationSettings = applicationSettings;

    }

    public async Task InvokeAsync(HttpContext context)
    {
        
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Replace("Bearer ", "");

        // Check if the request is for the login endpoint
        if (context.Request.Path.StartsWithSegments("/api/auth/login") 
            || context.Request.Path.StartsWithSegments("/api/auth/get-token")
            || context.Request.Path.StartsWithSegments("/api/auth/token-auhtenticated")
            )
        {
            // Allow anonymous access to the login endpoint
            await _next(context);
            return;
        }

        var tokenValidate = JWTTokenAuthincation.ValidateJwtToken(token, _applicationSettings);

        if (!tokenValidate)
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            return;
        }

        await _next(context);
    }
}
