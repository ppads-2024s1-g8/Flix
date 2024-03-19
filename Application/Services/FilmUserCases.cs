using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract.Extraction.Api.Application.Gateway;
using Contract.Extraction.Api.Domain.Cases;
using Contract.Extraction.Api.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Contract.Extraction.Api.Application.Services;
public class FilmUserCases : IFilmUserCases
{
    private readonly IFilmRepository _filmRepository;
    private List<Filme> listFilmes = new List<Filme>();

    public FilmUserCases(IFilmRepository filmGateway)
    {
        _filmRepository = filmGateway;
    }

    public void DeleteFilm(string nome)
    {
        
    }

    public Filme GetFilm(string nome)
    {
        return _filmRepository.GetFilm(nome);
    }

    public void PostFilm(Filme filme)
    {
        Console.WriteLine(filme.Ano);

    }

    public void PutFilm(string titulo, string diretor, string elenco, string pais, int ano)
    {
       
    }

    public void ConfigureServices(IServiceCollection services)
    {
        // Other service registrations...
        services.AddScoped<FilmUserCases>(); // Register FilmUserCases with the appropriate lifetime
    }
}
