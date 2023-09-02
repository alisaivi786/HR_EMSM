namespace HR.EMS.Common.DTOs.LogsDTO;

public class AddApiLogsDTO
{
    public string? RequestMethod { get; set; }
    public string? RequestPath { get; set; }
    public string? RequestHeaders { get; set; }
    public string? RequestBody { get; set; }
    public int StatusCode { get; set; }
    public string? ResponseHeaders { get; set; }
    public string? ResponseBody { get; set; }
}
