using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.EMS.Infrastructure.DBContext.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<Roles>
{
    public void Configure(EntityTypeBuilder<Roles> builder)
    {
        builder.HasData(
             new Roles
             {
                 Id = 1,
                 Name = "admin"
             },
             new Roles
             {
                 Id = 2,
                 Name = "employee"
             }
        );
    }
}
