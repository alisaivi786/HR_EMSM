using HR.EMS.Application.Configurations;
using HR.EMS.Application.Contracts.Presistence.DBContext;
using HR.EMS.Application.Contracts.UnitOfWork;
using HR.EMS.Presistence.DBContext;
using HR.EMS.Presistence.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HR.EMS.Infrastructure.ExtensionInfrastructure;
public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceInfrastructure(this IServiceCollection
        services, ApplicationSettings ApplicationSettings)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        var provider = ApplicationSettings.DbProvider.Value;
        services.AddDbContext<HrDatabaseContext>(options => {
            options.UseSqlServer(ApplicationSettings.ConnectionString.SqlConnection);
        });


        services.AddScoped<IHrDatabaseContext>(provider => provider.GetRequiredService<HrDatabaseContext>());

        return services;
    }
}