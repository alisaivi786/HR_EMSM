namespace HR.EMS.Infrastructure.DBContext.Configurations;

public class LeaveNatureConfiguration : IEntityTypeConfiguration<LeaveNatures>
{
    public void Configure(EntityTypeBuilder<LeaveNatures> builder)
    {
        builder.HasData(
             new LeaveNatures
             {
                 Id = 1,
                 Name = "Travel"
             },
             new LeaveNatures
             {
                 Id = 2,
                 Name = "Local"
             }
             // Add more dummy data as needed
        );
    }
}
