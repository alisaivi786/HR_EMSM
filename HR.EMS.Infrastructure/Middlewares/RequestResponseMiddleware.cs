using HR.EMS.Application.Configurations;
using HR.EMS.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
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
        var requestBody = await ReadRequestBody(request);

        // Log the request information
        Console.WriteLine($"Request Method: {request.Method}");
        Console.WriteLine($"Request Headers:");
        foreach (var (key, value) in request.Headers)
        {
            Console.WriteLine($"{key}: {value}");
        }
        Console.WriteLine($"Request Body:\n{requestBody}");

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

            Console.WriteLine($"Response Status Code: {response.StatusCode}");
            Console.WriteLine($"Response Headers:");
            foreach (var (key, value) in response.Headers)
            {
                Console.WriteLine($"{key}: {value}");
            }
            Console.WriteLine($"Response Body:\n{responseBody}");

            // Restore the original response body stream
            responseBodyStream.Seek(0, SeekOrigin.Begin);
            await responseBodyStream.CopyToAsync(originalResponseBody);
            context.Response.Body = originalResponseBody;
            stopwatch.Stop();
            var entity = new ApiLogs()
            {
                RowId = Guid.NewGuid(),
                DateCreated = DateTime.Now,
                CreatedBy = 1, // Replace with the actual user ID
                RequestMethod = request.Method,
                RequestPath = request.Path,
                RequestHeaders = string.Join(", ", request.Headers.Select(h => $"{h.Key}: {h.Value}")),
                RequestBody = requestBody,
                StatusCode = response.StatusCode,
                ResponseHeaders = string.Join(", ", response.Headers.Select(h => $"{h.Key}: {h.Value}")),
                ResponseBody = responseBody,
                RequestTime = startDate,
                ResponseTime = DateTime.Now,
                ElapsedMilliseconds = (int)stopwatch.ElapsedMilliseconds
            };

            InsertRequestResponseLog(entity);

        }
    }

    private async Task<string> ReadRequestBody(HttpRequest request)
    {
        request.EnableBuffering();
        var body = request.Body;
        var buffer = new byte[Convert.ToInt32(request.ContentLength)];
        await body.ReadAsync(buffer, 0, buffer.Length);
        body.Seek(0, SeekOrigin.Begin);
        return Encoding.UTF8.GetString(buffer);
    }

    public void InsertRequestResponseLog(ApiLogs log)
    {
        var applicationSettings = new ApplicationSettings();
        using SqlConnection connection = new(applicationSettings.ConnectionString.SqlConnection);
        connection.Open();

        string sqlQuery = @"
                INSERT INTO ApiLogs (
                    RowId, DateCreated, CreatedBy, DateModified, ModifiedBy, DateDeleted, DeletedBy, 
                    IsActive, IsDeleted, RequestMethod, RequestPath, RequestHeaders, RequestBody, 
                    StatusCode, ResponseHeaders, ResponseBody, RequestTime, ResponseTime, ElapsedMilliseconds
                ) 
                VALUES (
                    @RowId, @DateCreated, @CreatedBy, @DateModified, @ModifiedBy, @DateDeleted, @DeletedBy, 
                    @IsActive, @IsDeleted, @RequestMethod, @RequestPath, @RequestHeaders, @RequestBody, 
                    @StatusCode, @ResponseHeaders, @ResponseBody, @RequestTime, @ResponseTime, @ElapsedMilliseconds
                )";

        using SqlCommand command = new(sqlQuery, connection);
        command.Parameters.Add("@RowId", SqlDbType.UniqueIdentifier).Value = log.RowId;
        command.Parameters.Add("@DateCreated", SqlDbType.DateTime).Value = log.DateCreated;
        command.Parameters.Add("@CreatedBy", SqlDbType.BigInt).Value = log.CreatedBy ?? (object)DBNull.Value;
        command.Parameters.Add("@DateModified", SqlDbType.DateTime).Value = log.DateModified ?? (object)DBNull.Value;
        command.Parameters.Add("@ModifiedBy", SqlDbType.BigInt).Value = log.ModifiedBy ?? (object)DBNull.Value;
        command.Parameters.Add("@DateDeleted", SqlDbType.DateTime).Value = log.DateDeleted ?? (object)DBNull.Value;
        command.Parameters.Add("@DeletedBy", SqlDbType.BigInt).Value = log.DeletedBy ?? (object)DBNull.Value;
        command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = log.IsActive ?? (object)DBNull.Value;
        command.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = log.IsDeleted ?? (object)DBNull.Value;
        command.Parameters.Add("@RequestMethod", SqlDbType.NVarChar).Value = log.RequestMethod;
        command.Parameters.Add("@RequestPath", SqlDbType.NVarChar).Value = log.RequestPath;
        command.Parameters.Add("@RequestHeaders", SqlDbType.NVarChar).Value = log.RequestHeaders;
        command.Parameters.Add("@RequestBody", SqlDbType.NVarChar).Value = log.RequestBody;
        command.Parameters.Add("@StatusCode", SqlDbType.Int).Value = log.StatusCode;
        command.Parameters.Add("@ResponseHeaders", SqlDbType.NVarChar).Value = log.ResponseHeaders;
        command.Parameters.Add("@ResponseBody", SqlDbType.NVarChar).Value = log.ResponseBody;
        command.Parameters.Add("@RequestTime", SqlDbType.DateTime).Value = log.RequestTime ?? (object)DBNull.Value;
        command.Parameters.Add("@ResponseTime", SqlDbType.DateTime).Value = log.ResponseTime ?? (object)DBNull.Value;
        command.Parameters.Add("@ElapsedMilliseconds", SqlDbType.Int).Value = log.ElapsedMilliseconds ?? (object)DBNull.Value;

        int rowsAffected = command.ExecuteNonQuery();
        connection.Close();
        Console.WriteLine($"Rows affected: {rowsAffected}");

    }
}
