using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BrainBox.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(config => {
            config.RegisterServicesFromAssemblyContaining<ApplicationAssemblyReference>();
        });
        // Add validations from erroron
        services.AddValidatorsFromAssemblyContaining<ApplicationAssemblyReference>();
        return services;
    }
}