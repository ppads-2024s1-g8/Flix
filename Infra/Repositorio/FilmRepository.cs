using Contract.Extraction.Api.Application.Gateway;
using Contract.Extraction.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositorio;

public class FilmRepository : DbContext

{


    public FilmRepository(IFilmRepository filmRepository, DbContextOptions<FilmRepository> opts) : base(opts)
    {
        _filmRepository = filmRepository;
    }

    public DbSet<Filme> Filmes { get; set; }
    private readonly IFilmRepository _filmRepository;
    public void CreateFilmDbContext(Filme filme)
    {

    }


}
