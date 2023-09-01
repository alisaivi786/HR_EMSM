using System;
using System.Linq;
using System.Threading.Tasks;
using HR.EMS.Presistence.JWT;
using Microsoft.AspNetCore.Http;

public class JwtTokenValidationMiddleware
{
    private readonly RequestDelegate _next;

    public JwtTokenValidationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Replace("Bearer ", "");

        // Check if the request is for the login endpoint
        if (context.Request.Path.StartsWithSegments("/auth/login"))
        {
            // Allow anonymous access to the login endpoint
            await _next(context);
            return;
        }

        var tokenValidate = JWTTokenAuthincation.ValidateJwtToken(token);

        if (!tokenValidate)
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            return;
        }

        await _next(context);
    }
}
