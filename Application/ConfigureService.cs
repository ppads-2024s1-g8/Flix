using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract.Extraction.Api.Application.Services;


namespace Microsoft.Extensions.DependencyInjection;


public class ConfigureService
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Add services to the container.
        services.AddScoped<FilmUserCases>(); // Register FilmUserCases with the appropriate lifetime

        // Other service registrations...
    }
}
