using BrainBox.Application.Contracts;
using BrainBox.Application.Data;
using BrainBox.Domain.Primitives;
using BrainBox.Infraestructure.Persistence.Repositories;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BrainBox.Infraestructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddPersistence(configuration);
        return services;
    }

    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlServer")));
        services.AddScoped<IApplicationDbContext>(
            sp => sp.GetRequiredService<ApplicationDbContext>()
        );
        services.AddScoped<IUnitOfWork>(
            sp => sp.GetRequiredService<ApplicationDbContext>()
        );
        services.AddScoped<IProductRepository, ProductRepository>();
        return services;
    }
}