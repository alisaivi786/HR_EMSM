using HR.EMS.Application.Contracts.Presistence.DBContext;
using HR.EMS.Domain.Abstract;
using HR.EMS.Infrastructure.DBContext.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace HR.EMS.Presistence.DBContext;

public class HrDatabaseContext : DbContext, IHrDatabaseContext
{
    public HrDatabaseContext(DbContextOptions<HrDatabaseContext> options)
        : base(options)
    {
    }

    public DbSet<LeaveRequest> LeaveRequests { get; set; }
    public DbSet<LeaveAllocations> LeaveAllocations { get; set; }
    public DbSet<Users> Users { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<LeaveTypes> LeaveTypes { get; set; }
    public DbSet<LeaveNatures> LeaveNatures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new LeaveNatureConfiguration());
        modelBuilder.ApplyConfiguration(new LeaveTypeConfiguration());
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        base.OnModelCreating(modelBuilder);
    }

}
