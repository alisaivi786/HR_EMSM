using HR.EMS.Common.Errors;
using HR.EMS.Common.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Infrastructure.Middlewares;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            LogException(context.RequestServices.GetRequiredService<ILogger>(), ex);

            // Optionally, you can customize the response to the client
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Response.ContentType = "application/json";
            var errors = new List<Error>();
            var innerEx = ex;
            int countException = 0;
            while (innerEx != null)
            {
                errors.Add(new Error { Message = innerEx.Message ,Id = $"EX:{++countException}"});
                innerEx = innerEx.InnerException;
            }
            var response = new APIResponse<object>()
            {
                Error = errors,
                Success = false
            };
            // Write the JSON response to the client
            await context.Response.WriteAsync(System.Text.Json.JsonSerializer.Serialize(response));
            
        }
    }
    private void LogException(ILogger logger, Exception ex, int depth = 0)
    {
        // Log the current exception
        logger.Error(ex.Message, "An unhandled exception occurred (Depth: {Depth})", depth);

        // Check if there are inner exceptions and the depth is less than or equal to 2
        if (ex.InnerException != null && depth < 2)
        {
            // Recursively log inner exceptions
            LogException(logger, ex.InnerException, depth + 1);
        }
    }
}