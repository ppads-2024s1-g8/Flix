using Contract.Extraction.Api.Domain.Entities;
using Domain.Contracts.UseCases.Film;
using Flix.Application.InterfaceAdapters;

namespace Application.UseCases.Film;

public class CreateFilmUseCase : ICreateFilmUseCase
{
    private readonly IApplicationDbContext _dbContext;

    public CreateFilmUseCase(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> CreateAsync(CreateFilmInputDto input, CancellationToken cancellationToken)
    {
        ValidateInput(input);

        var film = new Filme(input.Titulo, input.Diretor, input.Elenco, input.Pais, input.Ano);

        await _dbContext.Filme.AddAsync(film, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return film.Id;
    }

    private static void ValidateInput(CreateFilmInputDto input)
    {
        if (input.Diretor == null)
        {
            throw new ArgumentException("Diretor não pode ser nulo", nameof(input.Diretor));
        }
    }
}
