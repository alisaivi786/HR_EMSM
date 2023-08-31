using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.EMS.Infrastructure.DBContext.Configurations;

public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveTypes>
{
    public void Configure(EntityTypeBuilder<LeaveTypes> builder)
    {
        builder.HasData(
             new LeaveTypes
             {
                 Id = 1,
                 Name = "Sick Leave",
                 DefaultDays = 10
             },
             new LeaveTypes
             {
                 Id = 2,
                 Name = "Annual Leave",
                 DefaultDays = 20
             },
             new LeaveTypes
             {
                 Id = 3,
                 Name = "Study Leave",
                 DefaultDays = 15
             },
             new LeaveTypes
             {
                 Id = 4,
                 Name = "Maternal Leave",
                 DefaultDays = 90
             }
             // Add more dummy data as needed
        );
    }
}
