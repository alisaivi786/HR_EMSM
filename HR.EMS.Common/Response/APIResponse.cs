namespace HR.EMS.Common.Response;

public class APIResponse<T>
{
    public T? Data { get; set; }
    public bool Success { get; set; } = true;
    public string Message { get; set; } = string.Empty;
    public List<Error>? Error { get; set; }
}
