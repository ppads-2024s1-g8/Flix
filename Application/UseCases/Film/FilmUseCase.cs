using Contract.Extraction.Api.Domain.Entities;
using Domain.Contracts.UseCases.Film;
using Flix.Application.InterfaceAdapters;
using Microsoft.EntityFrameworkCore;

namespace Application.UseCases.Film;

public class FilmUseCase : IFilmUseCase
{
    private readonly IApplicationDbContext _dbContext;

    public FilmUseCase(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> CreateAsync(FilmInputDto input, CancellationToken cancellationToken)
    {
        ValidateInput(input);

        var newFilm = new Filme(input.Titulo, input.Diretor, input.Elenco, input.Pais, input.Ano);

        await _dbContext.Filme.AddAsync(newFilm, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return newFilm.Id;
    }

    public async Task<List<Filme>> GetAllAsync(CancellationToken cancellationToken)
    {
        var allFilm = await _dbContext.Filme.ToListAsync();
        return allFilm;
    }

    public Task GetByIdAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<Filme> DeleteByIdFilmAsync(int id, CancellationToken cancellationToken)
    {
        var deletedFilm = await _dbContext.Filme.FirstOrDefaultAsync(filme => filme.Id == id);

        _dbContext.Filme.Remove(deletedFilm!);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return ($"Filme deletado: {deletedFilm}"!);

    }



    private static void ValidateInput(FilmInputDto input)
    {
        if (input.Diretor == null)
        {
            throw new ArgumentException("Diretor não pode ser nulo", nameof(input.Diretor));
        }
    }

    
}
