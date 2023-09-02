using HR.EMS.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Application.Contracts.Presistence.DBContext
{
    public interface IHrDatabaseContext
    {
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveAllocations> LeaveAllocations { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<LeaveTypes> LeaveTypes { get; set; }
        public DbSet<LeaveNatures> LeaveNatures { get; set; }
        public DbSet<ApiLogs> ApiLogs { get; set; }
    }
}
