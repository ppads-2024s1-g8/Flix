using Contract.Extraction.Api.Domain.Entities;
using Domain.Contracts.UseCases.Film;
using Domain.Entities;

namespace Domain.Contracts.UseCases.Book;

public interface IBookUseCase
{
    Task<string> CreateAsync(BookInputDto input, CancellationToken cancellationToken);
    Task<List<Entities.Book>> GetAllAsync(CancellationToken cancellationToken);
    Task<Entities.Book> GetByIdAsync(int id, CancellationToken cancellationToken);
    Task<Entities.Book> DeleteByIdAsync(int id, CancellationToken cancellationToken);
    Task<Entities.Book> PutByIdAsync(BookInputDto film, int id, CancellationToken cancellationToken);
}
