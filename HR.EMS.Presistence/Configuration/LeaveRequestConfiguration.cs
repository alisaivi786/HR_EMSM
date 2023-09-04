using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Presistence.Configuration
{
    public class LeaveRequestConfiguration : IEntityTypeConfiguration<LeaveRequest>
    {
        public void Configure(EntityTypeBuilder<LeaveRequest> builder)
        {
            builder.HasData(
                // Entry 1
                new LeaveRequest
                {
                    Id = 1,
                    StartDate = new DateTime(2023, 9, 1),
                    EndDate = new DateTime(2023, 9, 5),
                    LeaveTypeId = 1, // Set the appropriate LeaveTypeId
                    DateRequested = DateTime.Now,
                    RequestComments = "Vacation leave",
                    Approved = true,
                    Cancelled = false,
                    EmployeeId = 1 // Set the appropriate RequestingEmployeeId
                },
                // Entry 2
                new LeaveRequest
                {
                    Id = 2,
                    StartDate = new DateTime(2023, 10, 15),
                    EndDate = new DateTime(2023, 10, 20),
                    LeaveTypeId = 2, // Set the appropriate LeaveTypeId
                    DateRequested = DateTime.Now.AddDays(-5),
                    RequestComments = "Sick leave",
                    Approved = false,
                    Cancelled = true,
                    EmployeeId = 1 // Set the appropriate RequestingEmployeeId
                },
                // Entry 3
                new LeaveRequest
                {
                    Id = 3,
                    StartDate = new DateTime(2023, 11, 5),
                    EndDate = new DateTime(2023, 11, 10),
                    LeaveTypeId = 3, // Set the appropriate LeaveTypeId
                    DateRequested = DateTime.Now.AddDays(-10),
                    RequestComments = "Study leave",
                    Approved = true,
                    Cancelled = false,
                    EmployeeId = 1 // Set the appropriate RequestingEmployeeId
                },
               //Entry 10
                new LeaveRequest
                {
                    Id = 10,
                    StartDate = new DateTime(2023, 12, 25),
                    EndDate = new DateTime(2023, 12, 31),
                    LeaveTypeId = 1, // Set the appropriate LeaveTypeId
                    DateRequested = DateTime.Now.AddDays(-15),
                    RequestComments = "Holiday leave",
                    Approved = true,
                    Cancelled = false,
                    EmployeeId = 1 // Set the appropriate RequestingEmployeeId
                }
            );
        }
    }
}
