using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Presistence.Configuration
{
    public class LeaveAllocationConfiguration : IEntityTypeConfiguration<LeaveAllocations>
    {
        public void Configure(EntityTypeBuilder<LeaveAllocations> builder)
        {
            builder.HasData(
                new LeaveAllocations
                {
                    EmployeeId = 1,
                    LeaveTypeId = 1,
                    Id = 1,
                    // Fill in the other properties as needed
                },
                new LeaveAllocations
                {
                    EmployeeId = 1,
                    LeaveTypeId = 2,
                    Id = 2,
                    // Fill in the other properties as needed
                },
                new LeaveAllocations
                {
                    EmployeeId = 1,
                    LeaveTypeId = 3,
                    Id = 3,
                    // Fill in the other properties as needed
                },
                 new LeaveAllocations
                 {
                     EmployeeId = 2,
                     LeaveTypeId = 1,
                     Id = 4,
                     // Fill in the other properties as needed
                 },
                new LeaveAllocations
                {
                    EmployeeId = 2,
                    LeaveTypeId = 2,
                    Id = 5,
                    // Fill in the other properties as needed
                },
                new LeaveAllocations
                {
                    EmployeeId = 2,
                    LeaveTypeId = 3,
                    Id = 6,
                    // Fill in the other properties as needed
                },
                 new LeaveAllocations
                 {
                     EmployeeId = 2,
                     LeaveTypeId = 4,
                     Id = 7,
                     // Fill in the other properties as needed
                 }
            // Add more LeaveAllocations objects as needed
            );
        }

    }
}