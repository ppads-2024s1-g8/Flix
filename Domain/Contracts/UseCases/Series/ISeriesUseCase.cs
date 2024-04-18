using Contract.Extraction.Api.Domain.Entities;
using Domain.Contracts.UseCases.Film;
using Domain.Entities;

namespace Domain.Contracts.UseCases.Series;

public interface ISeriesUseCase
{
    Task<string> CreateAsync(SeriesInputDto input, CancellationToken cancellationToken);
    Task<List<Entities.Series>> GetAllAsync(CancellationToken cancellationToken);
    Task<Entities.Series> GetByIdAsync(int id, CancellationToken cancellationToken);
    Task<Entities.Series> DeleteByIdAsync(int id, CancellationToken cancellationToken);
    Task<Entities.Series> PutByIdAsync(SeriesInputDto Serie, int id, CancellationToken cancellationToken);
}
