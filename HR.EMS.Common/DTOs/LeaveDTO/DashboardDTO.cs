using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Common.DTOs.LeaveDTO
{
    public class DashboardDTO
    {
        public string? Pending { get; set; }
        public string? Reject { get; set; }
        public string? Approved { get; set; }
        public string? TotalEmployeeLeave { get; set; }
    }
}
