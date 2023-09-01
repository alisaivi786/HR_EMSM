using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Common.DTOs.LeaveDTO
{
    public class LeaveDeleteDTO
    {
        public int LeaveId { get; set; }
        public int RequestingEmployeeId { get; set; }
    }
}
