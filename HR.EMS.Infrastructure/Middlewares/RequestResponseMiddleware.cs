using HR.EMS.Application.Configurations;
using HR.EMS.Application.StaticHelpers;
using HR.EMS.Domain;
using HR.EMS.Presistence.AdoHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Serilog;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Infrastructure.Middlewares;



public class RequestResponseMiddleware
{
    private readonly RequestDelegate _next;

    public RequestResponseMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        var startDate = DateTime.Now;
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        // Capture the request information
        var request = context.Request;
        var originalRequestBody = request.Body;
        var requestBody = await StaticHelpers.ReadRequestBody(request);

        // Collect specific headers from the request
        var hostHeader = context.Request.Headers["Host"].FirstOrDefault();
        var authorizationHeader = context.Request.Headers["Authorization"].FirstOrDefault();
        var contentTypeHeader = context.Request.Headers["Content-Type"].FirstOrDefault();

        
        // Log the request data using Serilog
        Log.Information($"Request Method: {request.Method}, Path: {request.Path}, Headers: { new { Host = hostHeader, Authorization = authorizationHeader,ContentType = contentTypeHeader } }, Body: {requestBody}");


        // Capture the response information
        var originalResponseBody = context.Response.Body;
        using (var responseBodyStream = new MemoryStream())
        {
            context.Response.Body = responseBodyStream;

            // Continue processing the request
            await _next(context);

            // Log the response information
            context.Response.Body.Seek(0, SeekOrigin.Begin);
            var response = context.Response;
            var responseBody = await new StreamReader(response.Body).ReadToEndAsync();

            if(response.StatusCode == 200)
            {
                // Log the response data using Serilog
                Log.Information($"Response Status Code: {response.StatusCode}, Body: {responseBody}");
            }
            else
            {
                // Log the response data using Serilog
                Log.Error($"Response Status Code: {response.StatusCode}, Body: {responseBody}");
            }
            

            // Restore the original response body stream
            responseBodyStream.Seek(0, SeekOrigin.Begin);
            await responseBodyStream.CopyToAsync(originalResponseBody);
            context.Response.Body = originalResponseBody;
            stopwatch.Stop();

            var entity = new ApiLogs()
            {
                CreatedBy = 1, // Replace with the actual user ID
                RequestMethod = request.Method,
                RequestPath = request.Path,
                RequestHeaders = new
                {
                    Host = hostHeader,
                    Authorization = authorizationHeader,
                    ContentType = contentTypeHeader
                }.ToString(),
                RequestBody = requestBody,
                StatusCode = response.StatusCode,
                ResponseBody = responseBody,
                RequestTime = startDate,
                ResponseTime = DateTime.Now,
                ElapsedMilliseconds = (int)stopwatch.ElapsedMilliseconds
            };

            var result = AdoNetHelper.InsertQuery<ApiLogs>(entity);

            // Log the response data using Serilog
            Log.Information($"Log into Database: {result.Success} , Message: {result.Message}");

        }
    }
}
