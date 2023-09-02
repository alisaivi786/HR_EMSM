using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Common.DTOs.LogsDTO
{
    public class DetailsApiLogDTO
    {
        public int Id { get; set; }
        public string? RequestMethod { get; set; }
        public string? RequestPath { get; set; }
        public string? RequestHeaders { get; set; }
        public string? RequestBody { get; set; }
        public int StatusCode { get; set; }
        public string? ResponseHeaders { get; set; }
        public string? ResponseBody { get; set; }
    }
}
