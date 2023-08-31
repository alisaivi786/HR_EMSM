using HR.EMS.Application.Contracts.Presistence.DBContext;
using Microsoft.Extensions.Configuration;

namespace HR.EMS.Presistence;

public static class InfrastructureServicesRegistration
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection
        services, ApplicationSettings ApplicationSettings)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();

        var provider = ApplicationSettings.DbProvider.Value;
        services.AddDbContext<HrDatabaseContext>(options => {
            options.UseSqlServer(ApplicationSettings.ConnectionString.SqlConnection);
        });


        services.AddScoped<IHrDatabaseContext>(provider => provider.GetRequiredService<HrDatabaseContext>());

        return services;
    }
}
