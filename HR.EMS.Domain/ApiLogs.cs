namespace HR.EMS.Domain;

public class ApiLogs: BaseEntity
{
    public string? RequestMethod { get; set; }
    public string? RequestPath { get; set; }
    public string? RequestHeaders { get; set; }
    public string? RequestBody { get; set; }
    public int StatusCode { get; set; }
    public string? ResponseBody { get; set; }
    public DateTime? RequestTime { get; set; }
    public DateTime? ResponseTime { get; set; }
    public int? ElapsedMilliseconds { get; set; }

}
