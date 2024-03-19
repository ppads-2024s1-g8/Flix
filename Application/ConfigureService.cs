using System.Reflection;
using Application.UseCases.CreateFilm;
using Domain.Contracts.UseCases.CreateFilm;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureService
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
        });

        services.AddScoped<ICreateFilmUseCase, CreateFilmUseCase>();

        return services;
    }
}
