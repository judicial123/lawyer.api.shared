using lawyer.api.shared.application.Contracts.Interfaces.Persistence.Example;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.City;
using lawyer.api.shared.datastore.mssql.DatabaseContext;
using lawyer.api.shared.datastore.mssql.Model.MappingProfile;
using lawyer.api.shared.datastore.mssql.Repositories.Example;
using lawyer.api.shared.datastore.mssql.Repositories.City;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace lawyer.api.shared.datastore.mssql;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<LawyersContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("LawyersConnectionString")));
        services.AddAutoMapper(typeof(ApplicationMappingProfile).Assembly);
        services.AddScoped<IExampleCommandRepository, ExampleCommandRepository>();
        services.AddScoped<IExampleQueryRepository, ExampleQueryRepository>();
        services.AddScoped<ICityCommandRepository, CityCommandRepository>();
        services.AddScoped<ICityQueryRepository, CityQueryRepository>();

        return services;
    }
}