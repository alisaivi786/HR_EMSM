using HR.EMS.Application.Encryption;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.EMS.Infrastructure.DBContext.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<Users>
{
    public void Configure(EntityTypeBuilder<Users> builder)
    {
        var hasher = Encryption.GeneratePasswordHash("Password1", "EMS_HR_TEST");
        builder.HasData(
                 new Users
                 {
                     Id = 1,
                     FirstName = "Ali",
                     LastName = "Mushtaq",
                     Email = "ali.mushtaq@example.com",
                     UserName = "alimushtaq",
                     Password = hasher,
                     IsEmailConfirmed = true,
                     RoleId = 1 // Admin role
                 },
                 new Users
                 {
                     Id = 2,
                     FirstName = "Junaid",
                     LastName = "Mushtaq",
                     Email = "junaid.mushtaq@example.com",
                     UserName = "junaidmushtaq",
                     Password = hasher,
                     IsEmailConfirmed = true,
                     RoleId = 2 // Employee role
                 }
            );
    }
}

