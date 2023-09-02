
using HR.EMS.Application.Contracts.UnitOfWork;
using HR.EMS.Application.StaticHelpers;
using HR.EMS.Common.DTOs.LogsDTO;
using HR.EMS.Domain;
using HR.EMS.Presistence.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace HR.EMS.Infrastructure;
public class RequestResponseLoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<RequestResponseLoggingMiddleware> _logger;

    public RequestResponseLoggingMiddleware(RequestDelegate next, ILogger<RequestResponseLoggingMiddleware> logger)
    {
        _next = next ?? throw new ArgumentNullException(nameof(next));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // ... Logging before request processing ...

        // Capture the request data
        var request = context.Request;
        var requestBodyStream = new MemoryStream();
        var originalRequestBody = request.Body;

        // Capture request body
        await request.Body.CopyToAsync(requestBodyStream);
        requestBodyStream.Seek(0, SeekOrigin.Begin);
        var requestBodyText = new StreamReader(requestBodyStream).ReadToEnd();

        // Log the request data
        _logger.LogInformation("Request Method: {RequestMethod}, Path: {RequestPath}, Headers: {RequestHeaders}, Body: {RequestBody}",
            request.Method, request.Path, request.Headers, requestBodyText);

        // Replace the request body with the original stream
        request.Body = originalRequestBody;

        await _next(context);

       
    }
}
