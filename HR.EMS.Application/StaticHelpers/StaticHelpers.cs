using Microsoft.AspNetCore.Http;

namespace HR.EMS.Application.StaticHelpers;

public static class StaticHelpers
{
    public static string ReadStream(Stream stream)
    {
        using var reader = new StreamReader(stream, Encoding.UTF8);
        return reader.ReadToEnd();
    }
    public static async Task<string> ReadRequestBody(HttpRequest request)
    {
        request.EnableBuffering();
        var body = request.Body;
        var buffer = new byte[Convert.ToInt32(request.ContentLength)];
        _ = await body.ReadAsync(buffer, 0, buffer.Length);
        body.Seek(0, SeekOrigin.Begin);
        return Encoding.UTF8.GetString(buffer);
    }
    public static string GetColumnNames<T>(T entity)
    {
        var propertyNames = typeof(T)
            .GetProperties()
            .Where(p => !Attribute.IsDefined(p, typeof(ExcludeParameterAttribute)))
            .Select(p => p.Name);

        return string.Join(", ", propertyNames);
    }

    public static string GetParameterNames<T>(T entity)
    {
        var propertyNames = typeof(T)
            .GetProperties()
            .Where(p => !Attribute.IsDefined(p, typeof(ExcludeParameterAttribute)))
            .Select(p => $"@{p.Name}");

        return string.Join(", ", propertyNames);
    }
}
