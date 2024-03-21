using Contract.Extraction.Api.Domain.Entities;

namespace Domain.Contracts.UseCases.Film
{
    public interface IFilmUseCase
    {
        Task<int> CreateAsync(FilmInputDto input, CancellationToken cancellationToken);
        Task<List<Filme>> GetAllAsync(CancellationToken cancellationToken);
        Task GetByIdAsync(CancellationToken cancellationToken);
        Task<Filme> DeleteByIdFilmAsync(int id, CancellationToken cancellationToken);
    }
}
