using HR.EMS.Application.Contracts.Presistence.DBContext;
using HR.EMS.Domain.Abstract;
using HR.EMS.Infrastructure.DBContext.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using HR.EMS.Presistence.Configuration;

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
    public DbSet<ApiLogs> ApiLogs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Users>()
        .HasOne(u => u.Role)
        .WithMany() // No need for a collection here as it's a one-to-one relationship
        .HasForeignKey(u => u.RoleId);

        modelBuilder.ApplyConfiguration(new LeaveNatureConfiguration());
        modelBuilder.ApplyConfiguration(new LeaveTypeConfiguration());
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new LeaveRequestConfiguration());
        base.OnModelCreating(modelBuilder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies(); // Enable lazy loading
        base.OnConfiguring(optionsBuilder);
    }

}
