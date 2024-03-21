using System.Reflection;
using Application.UseCases.Film;
using Domain.Contracts.UseCases.Film;
using Flix.Application.InterfaceAdapters;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureService
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddScoped<IFilmUseCase, FilmUseCase>();
        return services;
    }
}
